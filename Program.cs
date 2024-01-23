internal class DirectoryCreate
{
    static void Main()
    {
        string path = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo";
        Directory.CreateDirectory(path);
        Console.WriteLine("Directory Demo Created");
        string path1 = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo\\Demo1";
        string path2 = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo\\Demo2";
        Directory.CreateDirectory(path1);
        Directory.CreateDirectory(path2);
        Console.WriteLine("Directory Demo1 Created");
        Console.WriteLine("Directory Demo2 Created");

        string filepath1 = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo\\myFile.txt";
        FileStream fs = File.Create(filepath1);
        if (File.Exists(filepath1))
        {
            Console.WriteLine("File Created in Demo Directory");
        }
        else
        {
            Console.WriteLine("File not Created in Demo Directory");
        }
        string filepath2 = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo\\myFile2.txt";
        FileInfo fileInfo = new FileInfo(filepath2);

        if (fileInfo.Exists)
        {
            Console.WriteLine("File already exists");
            Console.WriteLine("Writing content to the file");
            FileStream fs1 = fileInfo.Open(FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine("Hi there I am Erica");
            sw.Close();
        }
        else
        {
            fileInfo.Create();
            Console.WriteLine("File created in Demo Directory using FileInfo");
        }

        string fileToCopy = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo\\myFile2.txt";
        string destinationDirectory = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo\\Demo1\\";
        File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));

        string PathGetFilesName = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo";
        string PathGetDirectoriesName = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo";
        foreach (string f in Directory.GetFiles(PathGetFilesName))
        {
            Console.WriteLine(Path.GetFileName(f));
            Console.WriteLine(File.GetCreationTime(f));
            

        }
        foreach (string f in Directory.GetDirectories(PathGetDirectoriesName))
        {
            Console.WriteLine(Path.GetFileName(f));
        }

        DirectoryInfo di = new DirectoryInfo("C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo");
        foreach(FileInfo file in  di.GetFiles())
        {
            file.Delete();
        }
        foreach(DirectoryInfo dir in di.GetDirectories())
        {
            dir.Delete();
        }


    }
}