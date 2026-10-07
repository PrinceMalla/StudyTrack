using System.Text.Json;
using StudyTrack.Models;
using StudyTask = StudyTrack.Models.Task;

namespace StudyTrack
{
    public class JsonStorageService
    {
        private readonly string dataFolder;
        private readonly string subjectsFile;
        private readonly string tasksFile;

        public JsonStorageService()
        {
            dataFolder = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "data"
            );

            subjectsFile = Path.Combine(
                dataFolder,
                "subjects.json"
            );

            tasksFile = Path.Combine(
                dataFolder,
                "tasks.json"
            );

            Directory.CreateDirectory(dataFolder);
        }

        public void SaveSubjects(List<Subject> subjects)
        {
            string json = JsonSerializer.Serialize(
                subjects,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(subjectsFile, json);
        }

        public List<Subject> LoadSubjects()
        {
            try
            {
                if (!File.Exists(subjectsFile))
                {
                    return new List<Subject>();
                }

                string json = File.ReadAllText(subjectsFile);

                return JsonSerializer.Deserialize<List<Subject>>(json)
                       ?? new List<Subject>();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "There was a problem loading subjects.",
                    "StudyTrack",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return new List<Subject>();
            }
        }

        public void SaveTasks(List<StudyTask> tasks)
        {
            string json = JsonSerializer.Serialize(
                tasks,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(tasksFile, json);
        }

        public List<StudyTask> LoadTasks()
        {
            try
            {
                if (!File.Exists(tasksFile))
                {
                    return new List<StudyTask>();
                }

                string json = File.ReadAllText(tasksFile);

                return JsonSerializer.Deserialize<List<StudyTask>>(json)
                       ?? new List<StudyTask>();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "There was a problem loading tasks.",
                    "StudyTrack",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return new List<StudyTask>();
            }
        }
    }
}