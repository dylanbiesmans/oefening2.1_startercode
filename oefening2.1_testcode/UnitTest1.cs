using NUnit.Framework;
using System.Windows;
using System.Windows.Controls;
using oefening2._1_startercode;
namespace TestProject1
{
    [TestFixture]
    [Apartment(System.Threading.ApartmentState.STA)] // Belangrijk voor WPF!
    public class Tests
    {
        // 1. Hier vertel je de klasse dat er een _window bestaat
        private MainWindow _window;

        [SetUp]
        public void Setup()
        {
            if (Application.Current == null)
            {
                new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
            }

            _window = new MainWindow();
        }

        [Test]
        public void Opgave_A_Test()
        {
            // Nu zal _window wel herkend worden!
            _window.btnOne.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.That(_window.lblOne.Content.ToString(), Is.EqualTo("Ja"));
            Assert.That(_window.lblTwo.Content.ToString(), Is.EqualTo("Ja"));
            Assert.That(_window.lblThree.Content.ToString(), Is.EqualTo("Jaa"));
        }
    }
}