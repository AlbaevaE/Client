using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Data.OleDb;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
          BankClient cl1 = new BankClient(1,"Anna",18,"Jalal-Abad","12345678901234");
          BankClient cl2 = new BankClient(2,"Sia",30,"Osh","12345671234567");
          BankClient cl3 = new BankClient(3,"Olia",23,"Bishkek","76543217654321");

        List<BankClient> client = new List<BankClient>();
        client.Add(cl1);
        client.Add(cl2);
        client.Add(cl3);

        using (FileStream stream = File.OpenRead("/home/elvira/Documents/Client/Template/template.txt"))
        using (FileStream writeStream = File.OpenWrite("/home/elvira/Documents/Client/Result/result.txt"))
    {
        BinaryReader reader = new BinaryReader(stream);
        BinaryWriter writer = new BinaryWriter(writeStream);
         
        byte[] buffer = new Byte[1024];
        int bytesRead;
        while ((bytesRead =
                stream.Read(buffer, 0, 1024)) > 0)
        {
                writeStream.Write(buffer, 0, bytesRead);
              
            
        }
        writeStream.Close();
  
             for(int i = 0; i < client.Count; i++){
              if(client[i].INN.Equals("12345678901234")){
              System.IO.StreamWriter file = new System.IO.StreamWriter("/home/elvira/Documents/Client/Result/result.txt");
              file.WriteLine(client[i].id);
              file.WriteLine(client[i].Name);
              file.WriteLine(client[i].age);
              file.WriteLine(client[i].Address);
              file.WriteLine(client[i].INN);
              file.Close();
        }
      }
      
    }
  }
   
 class BankClient{
    public int id {get; set;}
    public string Name{get; set;}
    public int age{get; set;}
    public string Address{get; set;}
    public string INN{get; set;}

    public BankClient(int id, string Name,int age,string Address,string INN){
        this.id = id;
        this.Name = Name;
        this.age = age;
        this.Address = Address;
        this.INN = INN;
      }

    }
  
  }
}



    

