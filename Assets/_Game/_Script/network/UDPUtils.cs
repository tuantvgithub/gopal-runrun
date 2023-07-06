using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Globalization;

public class UDPUtils : MonoBehaviour
{
    private UdpClient client;
    private IPEndPoint ipEndPoint;
    private int port;

    private void Start()
    {
        ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
        client = new UdpClient(ipEndPoint);
        client.Connect("127.0.0.1", 8686);
        port = ((IPEndPoint) client.Client.LocalEndPoint).Port;
    }

    public void Send(float x, float y)
    {
        string msg = port + ";" + x + ";" + y;
        byte[] data = Encoding.UTF8.GetBytes(msg);
        client.Send(data, data.Length);
    }

    public string Receive()
    {
        byte[] data = client.Receive(ref ipEndPoint);
        return Encoding.UTF8.GetString(data);
    }

    // hàm này ko dùng làm gì cả
    // logic để lấy tọa độ x, y
    public void Gopal(string receivedData)
    {
        if (String.IsNullOrEmpty(receivedData)) return;

        string[] sub = receivedData.Split(";");
        string id = sub[0];
        float x = float.Parse(sub[1], CultureInfo.InvariantCulture.NumberFormat);
        float y = float.Parse(sub[2], CultureInfo.InvariantCulture.NumberFormat);
        Debug.Log(id + "(" + x + "," + y + ",0)");
    }
}
