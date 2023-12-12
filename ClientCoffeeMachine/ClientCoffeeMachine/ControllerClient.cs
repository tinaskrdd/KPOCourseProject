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
            string messageToSend = $"{cof.getCoffee()};{cof.getWater()};{cof.getSugar()};{cof.getMilk()}";
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
} 