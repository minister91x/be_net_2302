using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
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
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            return result;
        }
        static int CongHaiSo(int a, int b, int c)
        {
            int result = 0;
            try
            {
                result = a / b;
            }
            catch (Exception ex)
            {
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

        /// <summary>
        ///  Hàm này làm làm gì đó 
        /// </summary>
        /// <param name="x">x là giá trì từ bên trong lấy ra </param>
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

            /// CTRL+K + C
            /// 
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
        static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }

        static string HoanVi<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;

            return tmp.ToString();
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

                //foreach (var item in numbers)
                //{
                //    Console.WriteLine("cars {0}:", item);
                //}

                var currentDatetime = DateTime.Now;
                Console.WriteLine("currentDatetime {0}:", currentDatetime);

                var newDateTime = currentDatetime.AddHours(-1).AddMinutes(-30).AddSeconds(0);

                Console.WriteLine("newDateTime AddHours 2 hours {0}:", newDateTime);

                var timeSpan = new TimeSpan(-1, -30, 0);
                var newDatetimeWithTimeSpan = currentDatetime.Add(timeSpan);

                Console.WriteLine("newDateTime WithTimeSpan {0}:", newDateTime);

                var firstDayofMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 15, 5, 0);

                var lastDayOfMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

                Console.WriteLine("dd/MM/yyyy HH:mm:ss {0}:", firstDayofMonth.ToString("dd/MM/yy HH:mm:ss"));
                Console.WriteLine("yy/MM/dd HH:mm:ss {0}:", firstDayofMonth.ToString("yy/MM/dd HH:mm:ss"));

                //char[] formats = { 'd', 'D', 'f', 'F', 'g', 'G', 'M', 'm', 'O', 'o', 'R', 'r', 's', 't', 'T', 'u', 'U', 'Y', 'y' };
                //DateTime aDateTime = new DateTime(2022, 8, 23, 19, 30, 00);
                //foreach (char ch in formats)
                //{
                //    Console.WriteLine("\n======" + ch + " ========\n");
                //    // Các định dạng date-time được hỗ trợ.
                //    string[] formattedStrings = aDateTime.GetDateTimeFormats(ch);

                //    foreach (string format in formattedStrings)
                //    {
                //        Console.WriteLine(format);
                //    }
                //}
                var text = "15/03/2022";

                //A: Setup and stuff you don't want timed



                //var timerCobvert = new Stopwatch();
                //timerCobvert.Start();
                //var textToDateTime = Convert.ToDateTime(text, CultureInfo.InvariantCulture);

                //timerCobvert.Stop();

                //TimeSpan timeTakenConvert = timerCobvert.Elapsed;

                //Console.WriteLine("Convert DateTime Time taken {0}", timeTakenConvert.ToString(@"m\:ss\.fff"));

                //  var date = DateTime.ParseExact(text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                //DateTime dateValue;
                //if (!DateTime.TryParseExact(text, "dd/MM/yyyy HH:mm:ss", new CultureInfo("en-US"),
                //    DateTimeStyles.None, out dateValue))
                //{
                //}

                //string myText = "That's really neat! However I think the accepted answer still applies - if the font that the console is using does not support unicode characters, I believe this example will not work. I can't check that, however, as I don't have access to a Windows computer at the moment";
                //string myText2 = "That's really neat! However I think the accepted answer still applies - if the font that the console is using does not support unicode characters, I believe this example will not work. I can't check that, however, as I don't have access to a Windows computer at the moment";
                //var length = myText.Length;
                //Console.WriteLine("length of mytext {0}", length);
                //var textConcat = myText.Replace("mvc", "MVC 5");
                //Console.WriteLine("textConcat {0}", textConcat);

                //string myText3 = "1,2,3,4,";
                //string myText31 = "5,6,7";
                //Console.OutputEncoding = System.Text.Encoding.UTF8;
                //myText3 = myText3.Substring(0, myText3.Length - 1);

                //Console.WriteLine("substring : {0}", myText3);

                //for (int i = 0; i < myText3.Split(',').Length; i++)
                //{
                //    Console.WriteLine("vị trí : {0} - giá trị: {1}", i, myText3.Split(',')[i]);
                //}


                //var timer = new Stopwatch();
                //timer.Start();

                //var mytext4 = myText + myText2;
                //Console.WriteLine("mytext4 : {0}", mytext4);
                //timer.Stop();

                //TimeSpan timeTaken = timer.Elapsed;
                //Console.WriteLine("String concat Time taken {0}", timeTaken.ToString(@"m\:ss\.fff"));


                //var timerCobvert = new Stopwatch();
                //timerCobvert.Start();

                //var mytext5 = new StringBuilder("That's really neat! However I think the accepted answer still applies - if the font that the console is using does not support unicode characters, I believe this example will not work. I can't check that, however, as I don't have access to a Windows computer at the moment");
                //var mytext6 = mytext5.Append("That's really neat! However I think the accepted answer still applies - if the font that the console is using does not support unicode characters, I believe this example will not work. I can't check that, however, as I don't have access to a Windows computer at the moment");
                //Console.WriteLine("mytext6 : {0}", mytext6);

                //var hash = GetMd5Hash(myText3);
                //Console.WriteLine("hash md5 : {0}", hash);

                //timerCobvert.Stop();

                //TimeSpan timeTakenConvert = timerCobvert.Elapsed;

                //Console.WriteLine("StringBuilder Time taken {0}", timeTakenConvert.ToString(@"m\:ss\.fff"));

                //int ref1 = 10;
                //int ref2 = 11;
                //double refd1 = 10;
                //double refd2 = 11;
                //Console.WriteLine("HoanVi string {0}", HoanVi(ref myText3, ref myText31));

                //Console.WriteLine("HoanVi int {0}",  HoanVi(ref ref1, ref ref2));

                //Console.WriteLine("HoanVi double {0}", HoanVi(ref refd1, ref refd2));

                //GenericClass<int> intGenericClass = new GenericClass<int>(86);// Khời tạo class 
                //intGenericClass.genericProperty = 2017;
                //intGenericClass.genericMethod(2019);



                //GenericClass<string> strGenericClass = new GenericClass<string>("Welcome to");
                //strGenericClass.genericProperty = "Mr Quân";
                //strGenericClass.genericMethod("lop_aspnet");


                //ArrayList arrayList = new ArrayList();
                //arrayList.Add(1);
                //arrayList.Add("thứ 2");
                //arrayList.Add(true);

                //for (int i = 0; i < arrayList.Count; i++)
                //{
                //    Console.WriteLine("arrayList value {0}", arrayList[i]);

                //}

                //foreach (var item in arrayList)
                //{
                //    Console.WriteLine("item value {0}", item);
                //}

                //var parent = new ClassParent();

                //var class_children = new ClassChirldren();

                //var class_brochildren = new ClassBroChirldren();

                //class_children = new ClassBroChirldren();

                //var epkieu = (ClassBroChirldren)class_children;

                //var productManager = new ProductManager();

                //Console.WriteLine("Mời nhập lựa chọn");
                //Console.WriteLine("1: them product");
                //Console.WriteLine("2: hien thi danh sach san pham");
                //Console.WriteLine("3: sua product");
                //var chooose = Convert.ToInt32(Console.ReadLine());
                //switch (chooose)
                //{
                //    case 1:
                //        var product = new Product();
                //        Console.WriteLine("Mời nhập teen sanr phaam");
                //        var ten = Console.ReadLine();
                //        product.Name = ten;
                //        productManager.InsertProduct(product);

                //        break;
                //    case 2:

                //        var list = productManager.GetProucts();
                //        foreach (var item in list)
                //        {
                //            Console.WriteLine("productName {0}:", item);
                //        }
                //        break;
                //}

                //var listCheckIn = new List<CheckinDate>();
                //var CheckInDate = new CheckinDate();


                //CheckInDate.HourCheckIn = 8;
                //CheckInDate.CheckInDate = new DateTime(2023, 03, 31);
                //listCheckIn.Add(CheckInDate);

                var dbContext = new StudentModels();

                var product = new Product();
                product.Name = "Iphone 15";
                product.Price = 100000000;
                product.Quantity = 100;

                //var product2 = new Product
                //{
                //    Name = "Iphone 15",
                //    Quantity = 100,
                //    Price = 1000000,
                //    Total = 10000000
                //};

                dbContext.product.Add(product);
                var result = dbContext.SaveChanges();

                //CTRL+ K +C 
                //CTRL+K+U
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                throw;
            }

        }



    }
}
