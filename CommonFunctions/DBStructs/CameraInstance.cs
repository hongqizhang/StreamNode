using System;
using System.Text.Json.Serialization;
using FreeSql.DataAnnotations;
using GB28181.Sys.Model;

namespace CommonFunctions.DBStructs
{
    [Table(Name = "Camera")]
    [Index("cmr_cameraid", "CameraId", true)]
    [Index("cmr_cameraname", "CameraName", false)]
    [Index("cmr_dept", "DeptId,PDetpId", false)]
    [Index("cmr_deptex", "DeptName", false)]
    [Index("cmr_enablelive", "EnableKive", false)]
    [Serializable]
    public class CameraInstance
    {
        private long _id;
        private string _cameraId;
        private string _cameraName;
        private bool? _mobileCamera;
        private string? _deptId;
        private string? _deptName;
        private string? _pDetpId;
        private string? _pDetpName;
        private string _cameraIpAddress;
        private string? _cameraChannelLable; //如果是28181设备，就是通道id
        private string? _cameraDeviceLable; //如果是28181设备，就是设备id
        private CameraType _cameraType;
        private string? _ifRtspUrl; //如果是rtsp,那么rtsp的地址
        private bool? _ifGB28181Tcp = false; //如果是gb28181是否采用tcp方式进行推流
        private string _pushMediaServerId; //推去哪个流媒体的id
        private bool _enableLive;
        private bool? _enablePtz;
        private DateTime? _createTime;
        private DateTime? _updateTime;
        private int? _retryTimes;


        [Column(IsPrimary = true, IsIdentity = true)]
        public long Id
        {
            get => _id;
            set => _id = value;
        }

        public string CameraId
        {
            get => _cameraId;
            set => _cameraId = value;
        }

        public string CameraName
        {
            get => _cameraName;
            set => _cameraName = value;
        }

        /// <summary>
        /// 是否为移动摄像头，如果是移动摄像头，将不再判定它的ip地址是否一致
        /// </summary>
        public bool? MobileCamera
        {
            get => _mobileCamera;
            set => _mobileCamera = value;
        }

        public string? DeptId
        {
            get => _deptId;
            set => _deptId = value;
        }

        public string? DeptName
        {
            get => _deptName;
            set => _deptName = value;
        }

        public string? PDetpId
        {
            get => _pDetpId;
            set => _pDetpId = value;
        }

        public string? PDetpName
        {
            get => _pDetpName;
            set => _pDetpName = value;
        }

        public string CameraIpAddress
        {
            get => _cameraIpAddress;
            set => _cameraIpAddress = value;
        }

        public string? CameraChannelLable //如果是28181设备，就是通道id
        {
            get => _cameraChannelLable;
            set => _cameraChannelLable = value;
        }

        public string? CameraDeviceLable //如果是28181设备，就是设备id
        {
            get => _cameraDeviceLable;
            set => _cameraDeviceLable = value;
        }

        [Column(MapType = typeof(string))]
        public CameraType CameraType
        {
            get => _cameraType;
            set => _cameraType = value;
        }

        public string? IfRtspUrl
        {
            get => _ifRtspUrl;
            set => _ifRtspUrl = value;
        }

        public bool? IfGb28181Tcp
        {
            get => _ifGB28181Tcp;
            set => _ifGB28181Tcp = value;
        }

        public string PushMediaServerId
        {
            get => _pushMediaServerId;
            set => _pushMediaServerId = value;
        }

        public bool EnableLive
        {
            get => _enableLive;
            set => _enableLive = value;
        }


        public bool? EnablePtz
        {
            get => _enablePtz;
            set => _enablePtz = value;
        }

        public DateTime? CreateTime
        {
            get => _createTime;
            set => _createTime = value;
        }

        public DateTime? UpdateTime
        {
            get => _updateTime;
            set => _updateTime = value;
        }

        [JsonIgnore]
        [Column(IsIgnore = true)]
        public int? RetryTimes
        {
            get => _retryTimes;
            set => _retryTimes = value;
        }
    }
}