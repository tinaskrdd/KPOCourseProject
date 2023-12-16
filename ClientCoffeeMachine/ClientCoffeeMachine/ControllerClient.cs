using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

public static class Controller
{
    public static Coffee brewCoffee(int beverageChoice, int sugarChoice) 
    {
        Coffee coffee;
        if (beverageChoice == 1)
        {
            coffee = new Espresso();
        } else if (beverageChoice == 2)
        {
            coffee = new Cappuccino();
        } else
        {
            coffee = new Americano();
        }
        
        coffee.adjustSugar(sugarChoice);
        return coffee;
    }

    public static string  updateServer(Coffee cof, UdpClient udpClient, int port)
    {
        try
        {
            string messageToSend = $"{cof.GetType()};{cof.getCoffee()};{cof.getWater()};{cof.getSugar()};{cof.getMilk()}";
            byte[] sendBytes = Encoding.ASCII.GetBytes(messageToSend);
            udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", port);

            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivedBytes = udpClient.Receive(ref serverEndPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

             return "Received message from server: " + receivedMessage;
        }
        catch (Exception ex)
        {
            return "Error" + ex.Message;
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public static string requestTotal(UdpClient udpClient, int port)
    {
        try
        {
            string messageToSend = "total";
            byte[] sendBytes = Encoding.ASCII.GetBytes(messageToSend);
            udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", port);

            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivedBytes = udpClient.Receive(ref serverEndPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

            return receivedMessage;
        }
        catch (Exception ex)
        {
            return "Error" + ex.Message;
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public static (int, int, int, int) checkBeforeBrewing(UdpClient udpClient, int port)
    {
        int coffee, water, milk, sugar;
        string serverResources = Controller.requestTotal(udpClient, port);

        string[] parts = serverResources.Split(';');
        if (parts.Length == 4)
        {
            coffee = int.Parse(parts[0]);
            water = int.Parse(parts[1]);
            milk = int.Parse(parts[2]);
            sugar = int.Parse(parts[3]);
        }
        else
        {
            coffee = 0;
            water = 0;
            milk = 0;
            sugar = 0;
        }

        return (coffee, water, milk, sugar);
    }

    public static void sendToServerCoffeeStatus(UdpClient udpClient, int port)
    {
        try
        {
            string messageToSend = "coffee";
            byte[] sendBytes = Encoding.ASCII.GetBytes(messageToSend);
            udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", port);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public static void sendToServerWaterStatus(UdpClient udpClient, int port)
    {
        try
        {
            string messageToSend = "water";
            byte[] sendBytes = Encoding.ASCII.GetBytes(messageToSend);
            udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", port);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public static void sendToServerMilkStatus(UdpClient udpClient, int port)
    {
        try
        {
            string messageToSend = "milk";
            byte[] sendBytes = Encoding.ASCII.GetBytes(messageToSend);
            udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", port);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public static void sendToServerSugarStatus(UdpClient udpClient, int port)
    {
        try
        {
            string messageToSend = "sugar";
            byte[] sendBytes = Encoding.ASCII.GetBytes(messageToSend);
            udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", port);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
} 