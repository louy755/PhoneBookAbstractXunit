using System;
namespace PhoneBookAbstract
{
    public static class Record
    {
        static int counter = 0;
        static public  string CreateRecord(int id, string name, string number)
        {
            counter++;
            return id + "-" + " " + name + " " + number ;
        }
    }
}
