using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueshiman.ZoomRecordingArchiver.ApiModel;

namespace Ueshiman.ZoomRecordingArchiver.Mapper
{
    public class RecordingMapper
    {
        public Recording RecordingMapFrom(RecordingForJson source)
        {
            return new Recording()
            {
                from = source.from,
                to = source.to,
                next_page_token = source.next_page_token,
                page_count = source.page_count,
                page_size = source.page_size,
                total_records = source.total_records,
                meetings = source.meetings?.Select(MeetingMapFrom).ToArray(),
            };
        }

        public Meeting MeetingMapFrom(MeetingFoJson source)
        {
            return new Meeting()
            {
                userId = source.userId,
                account_id = source.account_id,
                duration = source.duration,
                host_id = source.host_id,
                id = source.id,
                recording_count = source.recording_count,
                start_time = source.start_time,
                topic = source.topic,
                total_size = source.total_size,
                type = source.type,
                uuid = source.uuid,
                share_url = source.share_url,
                recording_files = source.recording_files?.Select(FileMapFrom).ToArray(),
            };
        }

        public Recording_File FileMapFrom(Recording_File_forJson source)
        {
            return new Recording_File()
            {
                deleted_time = source.deleted_time,
                download_url = source.download_url,
                file_path = source.file_path,
                file_size = source.file_size,
                file_type = source.file_type,
                file_extension = source.file_extension,
                id = source.id,
                meeting_id = source.meeting_id,
                play_url = source.play_url,
                recording_end = DateTimeOffset.TryParse(source.recording_end, out DateTimeOffset recordingEnd) ? recordingEnd : null,
                recording_start = source.recording_start,
                recording_type = source.recording_type,
                status = source.status,
            };
        }


    }
}
