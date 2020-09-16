using System.IO;
using System;
using System.Collections.Generic;
using System.Collections;

namespace comandas.Scripts
{
    class FileManager
    {
        string fileName;

        public FileManager(string file) {
            this.fileName = file;
            if (!File.Exists(@Directory.GetCurrentDirectory() + @"/" + @fileName)) {
                StreamWriter sw = new StreamWriter(@Directory.GetCurrentDirectory() + @"/" + @fileName);
                sw.Close();
            }
        }
        public FileManager(string directoryPath, string file) {
            this.fileName = @directoryPath + @"/" + @file;
            if (!File.Exists(@Directory.GetCurrentDirectory() + @"/" + @fileName)) {
                Directory.CreateDirectory(@Directory.GetCurrentDirectory() + @"/" + @directoryPath);
                StreamWriter sw = new StreamWriter(@Directory.GetCurrentDirectory() + @"/" + @fileName);
                sw.Close();
            }
        }

        public List<string> getLines() {
            List<string> lines = new List<string>();
            StreamReader sr = new StreamReader(@Directory.GetCurrentDirectory() + @"/" + @fileName);
            while (!sr.EndOfStream) {lines.Add(sr.ReadLine());}
            sr.Close();
            return lines;
        }
        public string getLine(int index) {
            return getLines()[index];
        }
        public void write(List<string> lines) {
            File.WriteAllLines(@Directory.GetCurrentDirectory() + @"/" + @fileName, lines);
        }
        public void writeline(string line) {
        	List<string> lines = getLines();
        	lines.Add(line);
            File.WriteAllLines(@Directory.GetCurrentDirectory() + @"/" + @fileName, lines);
        }

        public bool contains(string path) { return getString(path) != null; }

        public void set(string path, object argument){
			if (contains(path)){
				List<string> lines = getLines();
                for (int i = 0; i < lines.Count; i++) {
                    if (lines[i].StartsWith(path + ":")) { 
                    	if(argument == null) lines.RemoveAt(i);
                    	else lines[i] = path + ": " + argument;
                    }
                }
                write(lines);
			}else{
				writeline(path + ": " + argument);
			}
        }

        public string getString(string path) {
        	List<string> lines = getLines();
        	string lineWithPath = "";
        	for(int i = 0; i < lines.Count; i++){if(lines[i].StartsWith(path)) lineWithPath = lines[i];}
        	string[] result = lineWithPath.Split(':');
        	if(result[0] != "") {
        		string final = null;
				for(int i = 1; i < result.Length; i++){
                    if (result[i].StartsWith(" ")) final += result[i].Remove(0, 1);
                    else final += result[i];
                }
                return final;
        	} else {
        		return null;
        	}
        }
        public int getInt(string path) {
            string result = getString(path);
            if (result != "" || result != null) {
                try { return int.Parse(result); }
                catch (Exception) { return -1; }
            }
            return -1;
        }

       public float getFloat(string path) {
            string result = getString(path);
            if (result != "" || result != null) {
                try { return float.Parse(result); }
                catch (Exception) { return -1; }
            }
            return -1;
        }
        public double getDouble(string path) {
            string result = getString(path);
            if (result != "" || result != null) {
                try { return double.Parse(result); }
                catch (Exception) { return -1; }
            }
            return -1;
        }
        public bool getBool(string path) {
            string result = getString(path);
            if (result != "" || result != null)
            {
                try { return bool.Parse(result); }
                catch (Exception) { return false; }
            }
            return false;
        }
    }
}