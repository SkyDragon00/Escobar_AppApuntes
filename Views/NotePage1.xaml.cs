namespace Escobar_AppApuntes.Views;

public partial class NotePage1 : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "Domenica_Escobar.txt");
    public NotePage1()
    {
        InitializeComponent();

        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);
    }
    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        File.WriteAllText(_fileName, TextEditor.Text);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Delete the file.
        if (File.Exists(_fileName))
            File.Delete(_fileName);

        TextEditor.Text = string.Empty;
    }
}