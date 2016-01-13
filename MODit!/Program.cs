using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Net;

namespace MODit_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool modded = false;

            Console.WriteLine("Traugdor's Minecraft Modding Program");
            Console.WriteLine();
            Console.Write("Doing important stuff");
            string folderlocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
            folderlocation += @"\.minecraft";
            Console.Write(".");
            string modlocation = folderlocation + @"\mods";
            Console.Write(".");
            string coremodlocation = folderlocation + @"\coremods";
            Console.Write(".done");
            Console.WriteLine();
            Console.WriteLine("Minecraft folder set to:");
            Console.WriteLine(folderlocation);
            Console.WriteLine("Mods folder set to:");
            Console.WriteLine(modlocation);
            Console.WriteLine("Coremods folder set to:");
            Console.WriteLine(coremodlocation);
            Console.WriteLine();
            Console.WriteLine("Downloading files");

            WebClient downloader = new WebClient();
            if (File.Exists(folderlocation + @"\489.forgeversion"))
            {
                modded = true;
            }
            else
            {
                Console.WriteLine("Client is likely not modded.");
                Console.Write("Downloading modded client...");
                if (File.Exists(@"C:\temp\moddedcraft.zip"))
                {
                    Console.WriteLine("Client already downloaded! This is strange.");
                }
                else
                {
                    downloader.DownloadFile("http://dl.dropbox.com/u/60448852/forjamie.zip", @"C:\temp\moddedcraft.zip");
                    Console.Write("done");
                    Console.WriteLine();
                }

                Console.Write("Extracting modded client...");
                Shell32.Shell sc = new Shell32.Shell();
                Directory.CreateDirectory(@"C:\temp\moddedcraft");
                Shell32.Folder output = sc.NameSpace(@"C:\temp\moddedcraft");
                Shell32.Folder input = sc.NameSpace(@"C:\temp\moddedcraft.zip");
                output.CopyHere(input.Items(), 256);
                Console.Write("done");
                Console.WriteLine();

                Console.WriteLine("Cleaning up some things...");
                File.Delete(@"C:\temp\moddedcraft.zip");

                Console.Write("Installing modded client...");
                string clientsource = @"C:\temp\moddedcraft";
                new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory(clientsource, folderlocation, true);
                Console.Write("done");
                Console.WriteLine();

                Console.WriteLine("Cleaning up some more...");
                Directory.Delete(clientsource, true);

            }

            if (modded)
            {
                Console.WriteLine("Client already modded. Skipping modded client.");
            }
            
            //download and move mods.
            Console.WriteLine();
            Console.WriteLine("Downloading mods:");
            Console.Write("Redpower2 Core: ");
            if(File.Exists(modlocation + @"\RedPowerCore-2.0pr6.zip"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/RedPowerCore-2.0pr6.zip", modlocation + @"\RedPowerCore-2.0pr6.zip");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("Redpower2 Digital Package: ");
            if (File.Exists(modlocation + @"\RedPowerDigital-2.0pr6.zip"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/RedPowerDigital-2.0pr6.zip", modlocation + @"\RedPowerDigital-2.0pr6.zip");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("Redpower2 Mechanical Package: ");
            if (File.Exists(modlocation + @"\RedPowerMechanical-2.0pr6.zip"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/RedPowerMechanical-2.0pr6.zip", modlocation + @"\RedPowerMechanical-2.0pr6.zip");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("Redpower2 Compatibility Extension: ");
            if (File.Exists(modlocation + @"\RedPowerCompat-2.0pr6.zip"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/RedPowerCompat-2.0pr6.zip", modlocation + @"\RedPowerCompat-2.0pr6.zip");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("Balkon's Weapons Mod: ");
            if (File.Exists(modlocation + @"\Weaponmod.zip"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/Weaponmod.zip", modlocation + @"\Weaponmod.zip");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("ChickenBones Core for NEI: ");
            if (File.Exists(coremodlocation + @"\CodeChickenCore-0.7.1.0.jar"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/CodeChickenCore-0.7.1.0.jar", coremodlocation + @"\CodeChickenCore-0.7.1.0.jar");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("NEI Core: ");
            if (File.Exists(coremodlocation + @"\NotEnoughItems-1.4.5.1.jar"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/NotEnoughItems-1.4.5.1.jar", coremodlocation + @"\NotEnoughItems-1.4.5.1.jar");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("NEI - Redpower interface: ");
            if (File.Exists(modlocation + @"\NEI_RedPowerPlugin-1.4.3.jar"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/NEI_RedPowerPlugin-1.4.3.jar", modlocation + @"\NEI_RedPowerPlugin-1.4.3.jar");
                Console.Write("Done");
            }
            Console.WriteLine();
            Console.Write("Lanterns mod: ");
            if (File.Exists(modlocation + @"\Lanterns_1.1.5_Universal.zip"))
            {
                Console.Write("Already installed! :)");
            }
            else
            {
                downloader.DownloadFile("http://dl.dropbox.com/u/60448852/Lanterns_1.1.5_Universal.zip", modlocation + @"\Lanterns_1.1.5_Universal.zip");
                Console.Write("Done");
            }
            Console.WriteLine();
            //Console.Write("Railcraft mod: ");
            //if (File.Exists(modlocation + @"\Railcraft_1.4.6-6.14.0.0.zip"))
            //{
            //    Console.Write("Already installed! :)");
            //}
            //else
            //{
            //    downloader.DownloadFile("http://dl.dropbox.com/u/60448852/Railcraft_1.4.6-6.14.0.0.zip", modlocation + @"\Railcraft_1.4.6-6.14.0.0.zip");
            //    Console.Write("Done");
            //}
            //Console.WriteLine();
            //Console.Write("NEI - Railcraft interface: ");
            //if (File.Exists(modlocation + @"\NEIPlugins-1.0.4.1.jar"))
            //{
            //    Console.Write("Already installed! :)");
            //}
            //else
            //{
            //    downloader.DownloadFile("http://dl.dropbox.com/u/60448852/NEIPlugins-1.0.4.1.jar", modlocation + @"\NEIPlugins-1.0.4.1.jar");
            //    Console.Write("Done");
            //}
            //Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Program is finished. Enjoy your mods!");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
