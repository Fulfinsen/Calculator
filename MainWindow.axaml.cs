using System.Diagnostics;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Calculator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private double _firstNumber;
    private bool _waitingForSecondNumber = false;
    private string _currentOperator = "";


    private void OnClearClick(object sender, RoutedEventArgs e)
    {
        Display.Text = 0.ToString();
        _currentOperator = "";
        _waitingForSecondNumber = false;
        Debug.WriteLine("Clear click");
    }

    private void OnNegateClick(object sender, RoutedEventArgs e)
    {
        _firstNumber = double.Parse(Display.Text);
        Display.Text = (_firstNumber * -1).ToString();
        Debug.WriteLine("Negate click");
    }

    private void OnPercentClick(object sender, RoutedEventArgs e)
    {
        _firstNumber = double.Parse(Display.Text);
        Display.Text = (_firstNumber /100).ToString();
        Debug.WriteLine("Percent click");
    }

    private void OnDivideClick(object sender, RoutedEventArgs e)
    {
        _firstNumber = double.Parse(Display.Text);
        _currentOperator = "/";
        _waitingForSecondNumber = true;
        Display.Text = "0";
        Debug.WriteLine("Divide click");
    }

    private void OnSevenClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "7";
        }
        else
        {
            Display.Text += "7";
        }
    }
    private void OnEightClick(object sender, RoutedEventArgs e) {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "8";
        }
        else
        {
            Display.Text += "8";
        } }

    private void OnNineClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "9";
        }
        else
        {
            Display.Text += "9";
        }
    }

    private void OnMultiplyClick(object sender, RoutedEventArgs e)
    {
        _firstNumber = double.Parse(Display.Text);
        _currentOperator = "*";
        _waitingForSecondNumber = true;
        Display.Text = "0";
        Debug.WriteLine("Multiply click");
    }

    private void OnFourClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "4";
        }
        else
        {
            Display.Text += "4";
        }
    }

    private void OnFiveClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "5";
        }
        else
        {
            Display.Text += "5";
        }
    }

    private void OnSixClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "6";
        }
        else
        {
            Display.Text += "6";
        }
    }

    private void OnSubtractClick(object sender, RoutedEventArgs e)
    {
        _firstNumber = double.Parse(Display.Text);
        _currentOperator = "-";
        _waitingForSecondNumber = true;
        Display.Text = "0";
        Debug.WriteLine("Subtract click");
    }

    private void OnOneClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "1";
        }
        else
        {
            Display.Text += "1";
        }
    }
    private void OnTwoClick(object sender, RoutedEventArgs e) { 
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "2";
        }
        else
        {
            Display.Text += "2";
        }}

    private void OnThreeClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "3";
        }
        else
        {
            Display.Text += "3";
        }
    }

    private void OnAddClick(object sender, RoutedEventArgs e)
    {
        _firstNumber = double.Parse(Display.Text);
        _currentOperator = "+";
        _waitingForSecondNumber = true;
        Display.Text = "0";
        Debug.WriteLine("Add click");
    }

    private void OnZeroClick(object sender, RoutedEventArgs e)
    {
        if (Display.Text == "0" || _waitingForSecondNumber == false && Display.Text == "0")
        {
            Display.Text = "0";
        }
        else
        {
            Display.Text += "0";
        }
    }

    private void OnDecimalClick(object sender, RoutedEventArgs e)
    {
        if (!Display.Text.Contains("."))
        {
            Display.Text += ".";
            Debug.WriteLine("Decimal click");
        }
    }

    private void OnEqualsClick(object sender, RoutedEventArgs e)
    {
        if (!_waitingForSecondNumber) return;
        double secondNumber = double.Parse(Display.Text);
        if (_currentOperator == "/" && secondNumber == 0)
        {
            Display.Text = "Cannot divide by zero";
            return;
        }
        double result = _currentOperator switch
        {
            "+" => _firstNumber + secondNumber,
            "-" => _firstNumber - secondNumber,
            "/" => _firstNumber / secondNumber,
            "*" => _firstNumber * secondNumber,
            _ => secondNumber
        };

        Display.Text = result.ToString();
        _waitingForSecondNumber = false;
    }
}