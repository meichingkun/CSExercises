﻿using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            Console.Write("Please input the number of TV you wish to purchase: ");
            string tvQty = Console.ReadLine();

            Console.Write("Please input the number of DVD you wish to purchase: ");
            string dvdQty = Console.ReadLine();

            Console.Write("Please input the number of MP3 you wish to purchase: ");
            string mp3Qty = Console.ReadLine();

            int tvNum = Convert.ToInt32(tvQty);
            int dvdNum = Convert.ToInt32(dvdQty);
            int mp3Num = Convert.ToInt32(mp3Qty);

            double price = CalculateTotalPrice(tvNum, dvdNum, mp3Num);
            Console.WriteLine("The total price for the items are {0:C}", price);
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double discountItem = tvQty * 900 + dvdQty * 500;
            if (discountItem>5000 && discountItem <=10000)
            {
                double price = (discountItem * 0.9) + mp3Qty * 700;
                return (price);
            }
            if(discountItem >10000)
            {
                double price = (discountItem * 0.85) + mp3Qty * 700;
                return (price);
            }
            else
            {
                double price = discountItem + mp3Qty * 700;
                return (price);
            }
            

        }
    }
}