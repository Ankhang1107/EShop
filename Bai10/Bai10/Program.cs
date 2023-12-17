namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EngStudent student1 = new EngStudent("Anh1", 19, 7, 8, 9);
            EngStudent student2 = new EngStudent("Anh2", 20, 8, 8, 9);
            EngStudent student3 = new EngStudent("Anh3", 17, 8, 8, 8);
            EngStudent student4 = new EngStudent("Anh4", 16, 8, 9, 8);
            EngStudent student5 = new EngStudent("Anh5", 22, 10, 8, 8);


            HistoryStudent student6 = new HistoryStudent("Su1", 15, 7, 6, 9);
            HistoryStudent student7 = new HistoryStudent("Su2", 22, 7, 6, 9);
            HistoryStudent student8 = new HistoryStudent("Su3", 17, 7, 6, 9);
            HistoryStudent student9 = new HistoryStudent("Su4", 18, 7, 6, 9);
            HistoryStudent student10 = new HistoryStudent("Su5", 20, 7, 6, 9);


            var listStu = new List<BaseStudent>() 
            { student1,student1,student3,student4, student5
,             student6, student7, student8, student9, student10
            };

            
            //tạo ra 1 list hsinh điểm toán > 8
            var result1 = listStu.Where(s => s.Math > 8).ToList();


            //------------------- điểm trung bình < 9
            var result2 = new List<IStudent>();
            //var result2 = listStu.Where(s => s.CaculateAvg() < 9).ToList();
            foreach (var student in listStu)
            {
                if(student is IStudent std && std.CaculateAvg() < 9)
                {
                    result2.Add(std);
                }
            }
            


            //------------------- tuổi lẻ và sắp xếp theo tuổi tăng dần
            var result3 = listStu.Where(s => s.Age %2 != 0).OrderBy(s => s.Age).ToList();


            //lấy ra 3 hsinh đầu tiên của list
            var result4 = listStu.Take(3).ToList();

            //bỏ qua 3 hsinh đầu tiên và lấy ra 3 hsinh tiếp theo của list
            var result5 = listStu.Skip(3).Take(3).ToList();


            //tính tổng điểm toán của tất cả hsinh
            var result6 = listStu.Sum(s => s.Math);

            //phân loại hsinh theo điểm toán
            var result7 = listStu.GroupBy(s => s.Math);
            foreach(var item in result7)
            {
                Console.WriteLine(item.Key);
                foreach(var student in item)
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine("-----------");
            }


            //phân loại hsinh theo tuổi, lúc in thì sắp xếp theo thứ tự điểm toán tăng dần
            var result8 = listStu.GroupBy(s => s.Age);
            foreach (var item in result8)
            {
                Console.WriteLine($"Age: {item.Key}");
                foreach(var student in item.OrderBy(s=>s.Math))
                {
                    //Console.WriteLine(student.Name);
                    Console.WriteLine($"{student.Name} ---- {student.Age}");
                }
                Console.WriteLine("------------");
            }


            //lấy ra các hsinh giỏi sử trong list

            //cach 1
            var historyStudent = new List<HistoryStudent>();
            foreach(var item in listStu) 
            { 
                if(item is HistoryStudent hst)
                {
                    historyStudent.Add(hst);
                }
                
            }

            //cach 2
            var historyStudent2 = listStu.OfType<HistoryStudent>().ToList();

            Console.ReadKey();
        }
    }
}