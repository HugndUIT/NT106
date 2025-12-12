using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NT106.Q12._2_Lab02_24520602
{
    public partial class Lab02_Bai7 : Form
    {
        public Lab02_Bai7()
        {
            InitializeComponent();
        }

        private void ShowFileContent(string path)
        {
            pn_noidung.Controls.Clear();
            try
            {
                // Lấy đuôi file
                string Extension = Path.GetExtension(path).ToLower();
                // Ảnh dùng PictureBox hiển thị
                if (Extension == ".jpg" || Extension == ".png" || Extension == ".jpeg" || Extension == ".gif" ||
                    Extension == ".bmp" || Extension == ".ico" || Extension == ".webp" || Extension == "..tiff")
                {
                    // Tạo picturebox
                    PictureBox pb = new PictureBox();
                    // Lấy ảnh từ đường dẫn
                    pb.Image = Image.FromFile(path);
                    // Làm picturebox chiếm hết panel
                    pb.Dock = DockStyle.Fill;
                    // Điều chỉnh ảnh cho kín picturebox
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    // Thêm vào panel picturebox vừa tạo
                    pn_noidung.Controls.Add(pb);
                }
                // Text đọc nội dung và hiển thị trong TextBox
                else if (Extension == ".json" || Extension == ".txt" || Extension == ".cs" || Extension == ".sql" ||
                         Extension == ".html" || Extension == ".css" || Extension == ".js" || Extension == ".cpp" ||
                         Extension == ".java" || Extension == ".xml" || Extension == ".py" || Extension == ".md")
                {
                    // Tạo textbox
                    TextBox tb = new TextBox();
                    // Cho phép nhiều dòng
                    tb.Multiline = true;
                    // Làm textbox chiếm hết panel
                    tb.Dock = DockStyle.Fill;
                    // Cho phép cuộn ngang, dọc (both)
                    tb.ScrollBars = ScrollBars.Both;
                    // Lấy nội dung từ đường dẫn
                    tb.Text = File.ReadAllText(path);
                    // Thêm vào panel textbox vừa tạo
                    pn_noidung.Controls.Add(tb);
                }
                else
                {
                    MessageBox.Show("Không thể hiển thị loại file này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đọc file");
            }
        }

        private void tv_caythumuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string Path = e.Node.Tag.ToString();
            // Show file tồn tại
            if (File.Exists(Path))
            {
                ShowFileContent(Path);
            }
        }

        private void tv_caythumuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Xóa các node con hiện tại (nếu có)
            e.Node.Nodes.Clear();
            // Lấy đường dẫn thực từ thuộc tính Tag của node
            string path = e.Node.Tag.ToString();
            try
            {
                // Thêm các thư mục con vào node hiện tại
                foreach (var Dir in Directory.GetDirectories(path))
                {
                    TreeNode DirNode = new TreeNode(Path.GetFileName(Dir));
                    DirNode.Tag = Dir;
                    DirNode.Nodes.Add("...");
                    e.Node.Nodes.Add(DirNode);
                }
                // Thêm các file con vào node hiện tại
                foreach (var File in Directory.GetFiles(path))
                {
                    TreeNode FileNode = new TreeNode(Path.GetFileName(File));
                    FileNode.Tag = File;
                    e.Node.Nodes.Add(FileNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy cập thư mục");
            }
        }

        private void pn_noidung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lab02_Bai7_Load(object sender, EventArgs e)
        {
            // Dọn dẹp thư mục trước khi load nếu có
            tv_caythumuc.Nodes.Clear();
            // DriveInfo để lấy danh sách các ổ đĩa
            foreach (var Drive in DriveInfo.GetDrives())
            {
                // Tạo nút cây cho mỗi ổ đĩa
                TreeNode Node = new TreeNode(Drive.Name);
                // node.Tag sẽ lưu đường dẫn thực của ổ đĩa
                Node.Tag = Drive.RootDirectory.FullName;
                // Thêm ... để làm node con tạm để hiện dấu + cho phép mở rộng
                Node.Nodes.Add("...");
                // Add nút cây vào TreeView
                tv_caythumuc.Nodes.Add(Node);
            }
        }
    }
}
