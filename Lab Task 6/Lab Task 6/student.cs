using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class student
    {
        public string libName
        {
            get { return libName; }
            set { libName = value; }
        };
        public string libAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        };
        private Book[] listOfBook;
        private int listOfBookcount;
        public int listOfBookcount
        {
            get { return listOfBookcount; }
            set { listOfBookcount = value; }
        };
        public int totalBook
        {
            get { return int totalBook; ; }
            set { int totalBook; = value; }
        };
        public stuident(string libName; string libAddress; int totalBook)
        {
             this.libName = libName;
             this.libAddress = libAddress;
             this.totalBook = totalBook;
             listOfBook = new Book[150];
        }
        public void AddBook(listOfBook emp)
         {
        if (listOfBookcount > 150)

            listOfBook[listOfBookcount++]=emp;


        else
           Console.writeline("listOfBook is full");
        Public void ShowAlltotalBook
            
            {
            for (int i = 0; i < listOfBookcount; i++)

                totalBook[i] = ShowInfo();
             }


          }
    }
}
