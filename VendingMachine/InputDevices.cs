//////////////////////////////////////////////////////////////////////
//      Vending Machine (Actuators.cs)                              //
//      Written by Masaaki Mizuno, (c) 2006, 2007, 2008, 2010, 2011 //
//                      for Learning Tree Course 123P, 252J, 230Y   //
//                 also for KSU Course CIS501                       //  
//////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    // For each class, you can (must) add fields and overriding constructors
    public class Controller
    {
        public Controller()
        {

        }
        //SubtractCoinAmount()
        //NoCoinsRemail()
        //UpdateDisplay()
        //AttemptPurchase()
        Drink [] drinkInventory = new Drink [4];
        Coin[] coinInventory = new Coin[4];
    }

    public class Drink
    {
        int _numCans;
        int _price;
        string _name;
        Controller controller;

        public Drink(int nC, int p, string n)
        {
            _numCans = nC;
            _price = p;
            _name = n;
        }

        public int NumCans
        {
            get
            {
                return _numCans;
            }
            set
            {
                _numCans = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //Purchaseable();
        //Purchasemade();
        //SoldOut();
    }

    public class Coin
    {
        int _num;
        int _value;
        int _numReturn;
        Controller controller;

        public Coin()
        {

        }
        public Coin(int n, int v)
        {
            _num = n;
            _value = v;
        }

        public int Num
        {
            get
            {
                return _num;
            }
            set
            {
                _num = value;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }

        public int NumReturn
        {
            get
            {
                return _numReturn;
            }
            set
            {
                _numReturn = value;
            }
        }

        //DispensCoins();
    }



    public class CoinInserter
    {
        // add a field to specify an object that CoinInserted() will firstvisit
        Coin coin;

        // rewrite the following constructor with a constructor that takes an object
        // to be set to the above field
        public CoinInserter(Coin cn)
        {
            coin = cn;
        }
        public void CoinInserted()
        {
            // You can add only one line here
            UpdateCoinAmount(coin);
        }

        void UpdateCoinAmount(Coin cn)
        {
            cn.Num++;
        }
    }

    public class PurchaseButton
    {
        // add a field to specify an object that ButtonPressed() will first visit - [Controller]
        Drink drink;

        public PurchaseButton(Drink dk)
        {
            drink = dk;
        }
        public void ButtonPressed()
        {
            // You can add only one line here
            PurchaseMade(drink);
        }

        void PurchaseMade(Drink dk)
        {
            dk.NumCans--;
        }
    }

    public class CoinReturnButton
    {
        // add a field to specify an object that Button Pressed will visit - [Controller]
        Controller con;

        // replace the following default constructor with a constructor that takes
        // an object to be set to the above field
        public CoinReturnButton(Controller control)
        {
            con = control;
        }
        public void ButtonPressed()
        {
            // You can add only one lines here
        }
    }
}
