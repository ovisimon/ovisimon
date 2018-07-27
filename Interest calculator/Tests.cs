using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_calculator
{
    [TestFixture]
    class Tests
    {
        [TestCase]
        public void CalculatePerson1Total()
        {
            MyCalculator myCalc = new MyCalculator();
            Assert.AreEqual(16, myCalc.InterestPerCards(person1.Wallets[0].Cards));
        }

        [TestCase]
        public void CalculatePerson1PerCard()
        {
            MyCalculator myCalc = new MyCalculator();
            List<decimal> total = myCalc.InterestPerCard(person1.Wallets[0].Cards);
            Assert.IsTrue(total.Contains(1) && total.Contains(5) && total.Contains(10));
        }

        [TestCase]
        public void CalculatePerson2Total()
        {
            MyCalculator myCalc = new MyCalculator();
            decimal total = myCalc.TotalInterest(person2);
            Assert.AreEqual(16, total);
        }

        [TestCase]
        public void CalculatePerson2PerWallet()
        {
            MyCalculator myCalc = new MyCalculator();
            List<decimal> total = myCalc.InterestPerWallet(person2);
            Assert.IsTrue(total.Contains(11) && total.Contains(5));
        }

        [TestCase]
        public void CalculatePerson3Total()
        {
            MyCalculator myCalc = new MyCalculator();
            decimal total = myCalc.TotalInterest(person3);
            Assert.AreEqual(15, total);
        }

        public void CalculatePerson3PerWallet()
        {
            MyCalculator myCalc = new MyCalculator();
            List<decimal> total = myCalc.InterestPerWallet(person3);
            Assert.AreEqual(15, total);
        }

        [TestCase]
        public void CalculatePerson4Total()
        {
            MyCalculator myCalc = new MyCalculator();
            decimal total = myCalc.TotalInterest(person4);
            Assert.AreEqual(15, total);
        }

        public void CalculatePerson4PerWallet()
        {
            MyCalculator myCalc = new MyCalculator();
            List<decimal> total = myCalc.InterestPerWallet(person4);
            Assert.AreEqual(15, total);
        }

        // Person data for testing

        Person person1 = new Person
        {
            Id = 1,
            Name = "John Doe",
            Wallets = new Wallet[] {
                new Wallet
                {
                    Id = 1,
                    Cards = new Card[]
                    {
                        new Card
                        {
                            Id = 1,
                            Name = "Discover",
                            Rate = 0.01M,
                            Balance = 100
                        },
                        new Card
                        {
                            Id = 1,
                            Name = "MasterCard",
                            Rate = 0.05M,
                            Balance = 100
                        },
                        new Card
                        {
                            Id = 1,
                            Name = "Visa",
                            Rate = 0.1M,
                            Balance = 100
                        }
                    }
                }
            }
        };

        Person person2 = new Person
        {
            Id = 2,
            Name = "Jane Doe",
            Wallets = new Wallet[] {
                new Wallet
                {
                    Id = 1,
                    Cards = new Card[]
                    {
                        new Card
                        {
                            Id = 1,
                            Name = "Discover",
                            Rate = 0.01M,
                            Balance = 100
                        },
                        new Card
                        {
                            Id = 1,
                            Name = "Visa",
                            Rate = 0.1M,
                            Balance = 100
                        }
                    }
                },
                new Wallet
                {
                    Id = 1,
                    Cards = new Card[]
                    {
                        new Card
                        {
                            Id = 1,
                            Name = "MasterCard",
                            Rate = 0.05M,
                            Balance = 100
                        }
                    }
                }
            }
        };

        Person person3 = new Person
        {
            Id = 3,
            Name = "John Smith",
            Wallets = new Wallet[] {
                new Wallet
                {
                    Id = 1,
                    Cards = new Card[]
                    {
                        new Card
                        {
                            Id = 1,
                            Name = "MasterCard",
                            Rate = 0.05M,
                            Balance = 100
                        },
                        new Card
                        {
                            Id = 2,
                            Name = "Visa",
                            Rate = 0.1M,
                            Balance = 100
                        }
                    }
                }
            }
        };

        Person person4 = new Person
        {
            Id = 4,
            Name = "Jane Smith",
            Wallets = new Wallet[] {
                new Wallet
                {
                    Id = 1,
                    Cards = new Card[]
                    {
                        new Card
                        {
                            Id = 1,
                            Name = "Visa",
                            Rate = 0.1M,
                            Balance = 100
                        },
                        new Card
                        {
                            Id = 2,
                            Name = "MasterCard",
                            Rate = 0.05M,
                            Balance = 100
                        }
                    }
                }
            }
        };
    }
}

