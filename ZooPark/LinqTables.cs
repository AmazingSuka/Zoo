using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace ZooPark
{
    [Table]
    class Animal
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public int KindID {get; set;}

        [Column]
        public int CellID { get; set; }
    }

    [Table]
    class AnimalKind
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(CanBeNull = false)]
        public string Kind { get; set; }
    }

    [Table]
    class Zoo
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(CanBeNull = false)]
        public string Name { get; set; }

        [Column(CanBeNull = false)]
        public string Address { get; set; }

        [Column(CanBeNull = true)]
        public string Phone { get; set; }

        [Column(CanBeNull = false)]
        public string INN { get; set; }
    }

    [Table]
    class Cell
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(CanBeNull = false)]
        public string Name { get; set; }

        [Column(CanBeNull = false)]
        public Byte Places { get; set; }

        [Column(CanBeNull = false)]
        public int ZooID { get; set; }
    }

    [Table]
    class Client
    {
        [Column(CanBeNull = false)]
        public int ZooID { get; set; }

        [Column(CanBeNull = false)]
        public int TicketTypeID { get; set; }

        [Column(CanBeNull = false)]
        public DateTime DateOfPayment { get; set; }
    }

    [Table]
    class Duty
    {
        [Column(CanBeNull = false)]
        public int EmployerID { get; set; }

        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public DateTime Date { get; set; }
    }

    [Table]
    class Employer
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(CanBeNull = false)]
        public string Fio { get; set; }

        [Column(CanBeNull = false)]
        public Byte Age { get; set; }

        [Column(CanBeNull = false)]
        public int PostID { get; set; }

        [Column(CanBeNull = false)]
        public int ZooID { get; set; }

        [Column(CanBeNull = true)]
        public string Phone { get; set; }

        [Column(CanBeNull = true)]
        public string Email { get; set; }

        [Column(CanBeNull = false)]
        public string INN { get; set; }

        [Column(CanBeNull = false)]
        public DateTime JoinDate { get; set; }
    }

    [Table]
    class Post
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(CanBeNull = false)]
        public string Name { get; set; }

        [Column(CanBeNull = false)]
        public int Salary { get; set; }
    }

    [Table]
    class TicketType
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(CanBeNull = false)]
        public string Type { get; set; }

        [Column(CanBeNull = false)]
        public int Price { get; set; }
    }
}
