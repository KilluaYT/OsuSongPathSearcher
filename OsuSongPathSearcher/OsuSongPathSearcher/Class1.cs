using System;
using System.IO;

namespace OsuSongPathSearcher
{
    public class Class1
    {
        
        public void GetOsuSongPath()
        {

            String path = "";
                
               

                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                path += (@"\osu!\Songs");

                if (Directory.Exists(path))
                {
              
                OsuSongPath = path;
                Status = "Auto detected osu! song directory:";
            }
                else
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    path += (@"\osu!\Songs");

                    if (Directory.Exists(path))
                    {
                   
                    OsuSongPath = path;
                    Status = "Auto detected osu! song directory:";
                }

                    else
                    {
                        path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                        path += (@"\osu!\Songs");

                        if (Directory.Exists(path))
                        {
                   
                        OsuSongPath = path;
                        Status = "Auto detected osu! song directory:";
                    }
                        else
                        {
                            path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                            path += (@"\osu!\Songs");

                            if (Directory.Exists(path))
                            {
                            
                            OsuSongPath = path;
                            Status = "Auto detected osu! song directory:";
                        }
                            else
                            {
 
                            OsuSongPath = "";
                            Status = "Auto detecting osu! song folder failed.";
                        }
                        }
                    }
                
            }// just shit of copy+paste to check osu! song folder
        }
        public string OsuSongPath;
        public string Status;
    }
}
