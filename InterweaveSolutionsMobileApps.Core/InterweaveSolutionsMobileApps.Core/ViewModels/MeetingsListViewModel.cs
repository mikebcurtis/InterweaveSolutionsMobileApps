using InterweaveSolutionsMobileApps.Core.Models;
using InterweaveSolutionsMobileApps.Core.Services.Data;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core.ViewModels
{
    public class MeetingsListViewModel : BaseViewModel, IMeetingsListViewModel
    {
        private IEnumerable<Meeting> _meetings;
        private IMeetingService _meetingService;

        public IEnumerable<Meeting> Meetings
        {
            get
            {
                return _meetings;
            }

            set
            {
                _meetings = value;
                RaisePropertyChanged(() => Meetings);
            }
        }

        public MvxCommand AddCommand
        {
            get
            {
                return new MvxCommand(() => 
                    {
                        throw new NotImplementedException();
                    }
                );
            }
        }

        public MvxCommand OpenMeetingDetailView
        {
            get
            {
                return new MvxCommand(() => 
                    {
                        throw new NotImplementedException();
                    }
                );
            }
        }

        public MeetingsListViewModel(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        public override async void Start()
        {
            base.Start();
            await ReloadDataAsync();
        }

        protected override async Task InitializeAsync()
        {
            Meetings = await _meetingService.GetAllMeetingsAsync();
        }
    }
}
