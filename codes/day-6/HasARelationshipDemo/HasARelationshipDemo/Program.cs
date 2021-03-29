using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationshipDemo
{
    class Address
    {
        int flatNo;
        string apartmentName;
        string street;
        string locality;
        string place;
        string state;
        string country;
        long pinCode;
        public Address()
        {

        }

        public Address(int flatNo, string apartmentName, string street, string locality, string place, string state, string country, long pinCode)
        {
            this.flatNo = flatNo;
            this.apartmentName = apartmentName;
            this.street = street;
            this.locality = locality;
            this.place = place;
            this.state = state;
            this.country = country;
            this.pinCode = pinCode;
        }

        public int FlatNo { get => flatNo; set => flatNo = value; }
        public string ApartmentName { get => apartmentName; set => apartmentName = value; }
        public string Street { get => street; set => street = value; }
        public string Locality { get => locality; set => locality = value; }
        public string Place { get => place; set => place = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
        public long PinCode { get => pinCode; set => pinCode = value; }
    }
    class PersonalInfo
    {
        string name;
        string mailId;
        long mobileNumber;
        Nullable<long> landlineNumber;

        public PersonalInfo()
        {

        }

        public PersonalInfo(string name, string mailId, long mobileNumber, long? landlineNumber = null)
        {
            this.name = name;
            this.mailId = mailId;
            this.mobileNumber = mobileNumber;
            this.landlineNumber = landlineNumber;
        }

        public string Name { get => name; set => name = value; }
        public string MailId { get => mailId; set => mailId = value; }
        public long MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public long? LandlineNumber { get => landlineNumber; set => landlineNumber = value; }
    }
    class Employee
    {
        string name;
        //navigational properties
        Address localAddress;
        Address permanantAddress;
        PersonalInfo personalInfo;

        public Employee()
        {

        }

        public Employee(string name, Address localAddress, Address permanantAddress, PersonalInfo personalInfo)
        {
            this.name = name;
            this.localAddress = localAddress;
            this.permanantAddress = permanantAddress;
            this.personalInfo = personalInfo;
        }

        public string Name { get => name; set => name = value; }
        internal Address LocalAddress { get => localAddress; set => localAddress = value; }
        internal Address PermanantAddress { get => permanantAddress; set => permanantAddress = value; }
        internal PersonalInfo PersonalInfo { get => personalInfo; set => personalInfo = value; }
    }
    class Product
    {

    }
    class Order
    {
        Product[] products;

        public Order(Product[] products = null)
        {
            this.products = products;
        }

        internal Product[] Products { get => products; set => products = value; }
    }
    class Customer
    {
        Order[] orders;
        public Customer(Order[] orders = null)
        {
            this.orders = orders;
        }

        internal Order[] Orders { get => orders; set => orders = value; }
    }
    class Program
    {
        static void Main()
        {
            //Address local = new Address();
            //Address permanent = new Address();
            //PersonalInfo info = new PersonalInfo();
            //Employee employee = new Employee(localAddress: local, permanantAddress: permanent, personalInfo: info);

            Product[] products = new Product[]
            {
                new Product(),
                new Product(),
                new Product()
            };
            Order order = new Order();
            order.Products = new Product[] { products[0], products[1] };

            Customer customer = new Customer();
            customer.Orders = new Order[] { order };

            

            Employee[] employees = new Employee[]
            {
                new Employee("joy", new Address(1,"abc","","","bng","ka","ind", 560100), new Address(), new PersonalInfo()),
                new Employee("anil", new Address(2,"abc","","","bng","ka","ind", 560100), new Address(), new PersonalInfo()),
                new Employee("sunil", new Address(11,"abc","","","chn","ka","ind", 560100), new Address(), new PersonalInfo()),
                new Employee("mahesh",new Address(21,"abc","","","mum","ka","ind", 560100), new Address(), new PersonalInfo()),
            };
            foreach (Employee e in employees)
            {
                Address local = e.LocalAddress;
                if (local.Place == "bng")
                {
                    Console.WriteLine(e.Name);
                }
            }
        }
    }
}
