using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sid.Photograpy.PhotoEditor.Helper;
using Sid.Photograpy.PhotoEditor.Views.UserControls;
using Telerik.Windows.Controls;
using System.Windows.Forms;

namespace Sid.Photograpy.PhotoEditor.ViewModel
{
    public class CleanPhotosViewModel : ViewModelBase
    {
        private ObservableCollection<string> _imageTypes = new ObservableCollection<string>();
        private string _photoLocation = string.Empty;
        private ICommand _browsePhotoLocationCommand = null;
        private ucCleanPhotos _view = null;


        public ObservableCollection<string> ImageTypes
        {
            get { return _imageTypes; }
            set
            {
                _imageTypes = value;
                OnPropertyChanged(() => ImageTypes);
            }
        }

        public string PhotoLocation
        {
            get { return _photoLocation; }
            set { _photoLocation = value; }
        }

        public ICommand BrowsePhotoLocationCommand
        {
            get
            {
                if (_browsePhotoLocationCommand == null)
                    _browsePhotoLocationCommand = new RelayCommand(BrowsePhotoLocationCommand_Execute,
                        BrowsePhotoLocationCommand_CanExecute);

                return _browsePhotoLocationCommand;
            }

        }

        public ucCleanPhotos View
        {
            get { return _view; }
            set
            {
                _view = value;
                OnPropertyChanged(() => View);
            }
        }


        public CleanPhotosViewModel()
        {

        }


        private void BrowsePhotoLocationCommand_Execute(object param)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog(null);
        }

        private bool BrowsePhotoLocationCommand_CanExecute(object param)
        {
            return true;
        }
    }
}
