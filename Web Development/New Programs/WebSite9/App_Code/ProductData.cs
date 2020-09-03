using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

public class ProductData
{
    public int prodid;
    public string prodname;
    public float price;
    public string root="images/",imgpath;

    public ProductData()
    { }

    public ProductData(int prodid,string prodname,float price, string imgpath)
    {
        this.prodid = prodid;
        this.prodname = prodname;
        this.price = price;
        this.imgpath = root + imgpath;
    }

    public ArrayList generateProducts()
    {
        ArrayList stock = new ArrayList();
        stock.Add(new ProductData(1101, "Pen Drive 4 GB", 400.00f, "product1.jpeg"));
        stock.Add(new ProductData(1102, "Pen Drive 8 GB", 900.00f, "product2.jpg"));
        stock.Add(new ProductData(1103, "Mouse", 800.00f, "product3.jpg"));
        stock.Add(new ProductData(1104, "USB", 300.00f, "product4.jpg"));
        stock.Add(new ProductData(1105, "Printer", 1900.00f, "product5.png"));

        return stock;
    }
}