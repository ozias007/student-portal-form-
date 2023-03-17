using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace StudentApp
{
    internal class Filehandler
    {

        public void writeRegistration(string username,string password)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            if (!(File.Exists(path + @"\student_info.txt")))
            {
                File.Create(path + @"\student_info.txt");
            }
            List<Registration> registrations = new List<Registration>();
            FileStream  stream= new FileStream(path + @"\student_info.txt", FileMode.Append,FileAccess.Write);
            StreamWriter writer= new StreamWriter(stream);
            try
            {
                using (writer)
                {
                    writer.WriteLine("{0},{1}", username, password);
                    MessageBox.Show("data has been sucessfully added !! You now have an account  ");
                    
                }
                
            } catch(Exception exe)
            {
                MessageBox.Show("an error has occurred: "+exe.Message);
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
             
        }
        public bool GetVerification(string username, string password)
        {
            bool hasAccess = false;
            

            string path = System.AppDomain.CurrentDomain.BaseDirectory;
          

            FileStream stream = new FileStream( path + @"\student_info.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader= new StreamReader(stream);

            try
            {
                List<string> lines = new();

                string line = reader.ReadLine();

                while (!(string.IsNullOrEmpty(line)))
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }

                foreach (var l in lines)
                {

                    string[] details = l.Split(",");

                    string usr = details[0];
                    string pswrd = details[1];

                    if ((usr.ToLower().Trim() == username.ToLower().Trim()) && pswrd == password)
                    {
                        hasAccess = true;
                        break;
                    }
                    else
                    {

                        hasAccess = false;
                    }

                }
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }
            





            return hasAccess ;

        }


    }
}
