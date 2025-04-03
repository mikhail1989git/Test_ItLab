using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
using System.IO;
using System.Timers;
using Test_ItLab.ViewModels;
using Test_ItLab;

public class MainViewModel : ViewModelBase
{
    private Page _currentPage;
    private Timer _timer;

    public Page CurrentPage
    {
        get => _currentPage;
        set
        {
            _currentPage = value;
            OnPropertyChanged();
        }
    }

    //Page2
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    //Page3
    public string Code1 { get; set; }
    public string Code2 { get; set; }
    public string Code3 { get; set; }

    public MainViewModel()
    {
        NavigateToPage1();
    }

    public void NavigateToPage1()
    {
        CurrentPage = new Page1(this);
    }

    public void NavigateToPage2()
    {
        CurrentPage = new Page2(this);
    }

    public void NavigateToPage3()
    {
        CurrentPage = new Page3(this);
    }

    public void NavigateToPage4()
    {
        CurrentPage = new Page4(this);
        StartTimer();
    }

    private void StartTimer()
    {
        _timer = new Timer(20000);
        _timer.Elapsed += (s, e) =>
        {
            _timer.Stop();
            Application.Current.Dispatcher.Invoke(NavigateToPage1);
        };
        _timer.Start();
    }

    public void OpenPdf(string fileName)
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "Documents", fileName);

        if (File.Exists(path))
        {
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }
        else
        {
            MessageBox.Show($"Файл находящийся по пути: {path} не обнаружен.");
        }
    }

    public void VerifyCode()
    {
        if (Code1 == "0" && Code2 == "0" && Code3 == "0")
        {
            NavigateToPage4();
        }
        else
        {
            MessageBox.Show("Неверный код. Попробуйте снова.");
        }
    }
}