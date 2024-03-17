# MusicPlayer
MusicPlayer With C#.Net

![main](https://github.com/keesung98/MusicPlayer/assets/70887592/67b273c6-e31b-46f5-8fdd-ffb61e291164)

---

## play music app

### Select Song Code

```cs
private void btnSelectSongs_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();                      //Object OpenFileDialog ofd
    ofd.Multiselect = true;                                         //Multi Select OK
    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
    {
        files = ofd.SafeFileNames;
        paths = ofd.FileNames;
        for (int i = 0; i < files.Length; i++)
        {
            songListBox.Items.Add(files[i]);                        //save files name to List Box
        }
    }
}
```

### song List Box

```cs
private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
{
    axWindowsMediaPlayer.URL = paths[songListBox.SelectedIndex];    //Find songs paths & save UML
}
```
---

## Use
* Select Song >> files Paths
* Select Song >> List Box
* Play Music

