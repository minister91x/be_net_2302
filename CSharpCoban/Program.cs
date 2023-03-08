using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    internal class Program
    {
        static int CongHaiSo(int a, int b)
        {
            int result = 0;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException ex2)
            {

            }
            catch (OutOfMemoryException ex3)
            {

            }
            catch (Exception ex)
            {
                /// Console.WriteLine("Hệ thống đang bận.Vui lòng quay lại sau!");
                Console.WriteLine("{0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            return result;
        }
        static void ThamChieuThamTri(int x)
        {
            // khởi tạo ra 1 biến cục bộ 
            x = x * x;
            Console.WriteLine("X ở Hàm tham trị ={0}", x);
        }
        static void ThamChieuThamTri(ref int x)
        {
            //Sử dụng luôn biến đã được khai báo trước đó 
            x = x * x;
            Console.WriteLine(x);
        }

        static void ThamChieuThamTri_Out(out int x)
        {
            //Sử dụng luôn biến đã được khai báo trước đó 
            x = 200;
            Console.WriteLine(x);
        }
        public static void UserInput(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new DataTooLongExeption();
                throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        }

        struct People
        {
            public People(string _name, int _age)
            {
                Name = _name;
                Age = _age;
            }
            public string Name { get; set; }
            public int Age { get; set; }

            public int Run()
            {
                return 10;
            }
        }


        enum Enum_TransactionStatus
        {
            ThanhCong = 1,
            ThatBai = 0,
            DangVanChuyen = 2,
            ChoLayHang = 3
        }

        static void Main(string[] args)
        {
            // ấn F10 để đi debug từng dòng
            // dùng F11 để debug vào trong hàm 
            string myName = "My Name is QUÂN";

            var valiable = 10;

            var valiable1 = "text";
            myName = "abck";
            int a = 10;
            int b = 15;
            int a1 = 10;
            int b1 = 2;

            var d = CongHaiSo(a, b1);
            Console.WriteLine("{0} chia cho {1} = {2}", a, b1, d);
            var d1 = a1 + b1;

            // CTRL+K+D - fomat 
            // CTRL+K+C - comment 1 đoạn code 
            // CTRL+K+U  - uncommnent

            //Console.WriteLine("giá trị trước khi gọi hàm tham trị {0}", a);
            //ThamChieuThamTri(a);
            //Console.WriteLine("giá trị sau khi gọi hàm tham trị {0}", a);

            //Console.WriteLine("-------------------------------------------------");


            //Console.WriteLine("giá trị trước khi gọi hàm tham chiếu ref {0}", a);
            //ThamChieuThamTri(ref a);
            //Console.WriteLine("giá trị sau khi gọi hàm tham chiếu out {0}", a);

            //try
            //{
            //    var str = "demo custom exception";
            //    UserInput(str);
            //}
            //catch (DataTooLongExeption ex)
            //{
            //    throw ex;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            //var lstInt = new List<int>();
            //lstInt.Add(1);
            //lstInt.Add(2);
            //lstInt.Add(3);
            //lstInt.Add(4);

            //for (int i = 0; i < lstInt.Count; i++)
            //{
            //    Console.WriteLine("vi trí {0}- giá trị ={1}", i, lstInt[i]);
            //}

            //if (lstInt.Count > 0)
            //{
            //    foreach (var item in lstInt)
            //    {
            //        Console.WriteLine(" giá trị ={0}", item);
            //    }
            //}
            try
            {
                //Console.WriteLine("nhập giá tri:");
                //var input_keyboard = Console.ReadLine().ToString();

                //int input = int.Parse(Console.ReadLine());



                //var _peple = new People("MyName is Quân", 18);
                //Console.WriteLine("Name {0}:", _peple.Name);
                //Console.WriteLine("Age {0}:", _peple.Age);
                //Console.ReadLine();

                //var status = Convert.ToInt32(Enum_TransactionStatus.ThatBai);
                //var status2 = (int)Enum_TransactionStatus.ThatBai;
                //var status3 = int.Parse(Enum_TransactionStatus.ThatBai.ToString());


                string[] cars = { "Honda", "BMW", "Ford", "Mazda" };
                int[] numbers = { 0, 1, 8, 2, 5, 10, 3 };

                //Console.WriteLine("cars {0}:", cars[10]);
                Array.Sort(numbers);

                //for (int i = 0; i < cars.Length; i++)
                //{
                //    Console.WriteLine("cars {0}:", cars[i]);
                //}

                foreach (var item in numbers)
                {
                    Console.WriteLine("cars {0}:", item);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                throw;
            }

        }



    }
}
