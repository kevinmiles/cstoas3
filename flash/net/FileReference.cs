namespace flash.net {
	using System;

	using events;

	using Global;

	using utils;

	public class FileReference : EventDispatcher
	{
		/// <summary>
		/// The creation date of the file on the local disk.
		/// </summary>
		public readonly Date creationDate;

		/// <summary>
		/// The Macintosh creator type of the file, which is only used in Mac OS versions prior to Mac OS X.
		/// </summary>
		public readonly string creator;

		/// <summary>
		/// The <see cref="ByteArray"/> object representing the data from the loaded file after a successful call to the load() method.
		/// </summary>
		public readonly ByteArray data;

		/// <summary>
		/// The date that the file on the local disk was last modified.
		/// </summary>
		public readonly Date modificationDate;

		/// <summary>
		/// The name of the file on the local disk.
		/// </summary>
		public readonly string name;

		/// <summary>
		/// The size of the file on the local disk in bytes.
		/// </summary>
		public readonly double size;

		/// <summary>
		/// The file type.
		/// </summary>
		public readonly string type;

		/// <summary>
		/// Displays a file-browsing dialog box that lets the user select a file to upload.
		/// </summary>
		public bool browse(FileFilter[] typeFilter)
		{
			return default(bool);
		}

		/// <summary>
		/// Displays a file-browsing dialog box that lets the user select a file to upload.
		/// </summary>
		public bool browse()
		{
			return default(bool);
		}

		/// <summary>
		/// Cancels any ongoing upload or download operation on this <see cref="FileReference"/> object.
		/// </summary>
		public void cancel()
		{
		}

		/// <summary>
		/// Opens a dialog box that lets the user download a file from a remote server.
		/// </summary>
		public void download(URLRequest request, string defaultFileName)
		{
		}

		/// <summary>
		/// Opens a dialog box that lets the user download a file from a remote server.
		/// </summary>
		public void download(URLRequest request)
		{
		}

		/// <summary>
		/// Starts the load of a local file selected by a user.
		/// </summary>
		public void load()
		{
		}

		/// <summary>
		/// Opens a dialog box that lets the user save a file to the local filesystem.
		/// </summary>
		public void save(object data, string defaultFileName)
		{
		}

		/// <summary>
		/// Opens a dialog box that lets the user save a file to the local filesystem.
		/// </summary>
		public void save(object data)
		{
		}

		/// <summary>
		/// Starts the upload of a file selected by a user to a remote server.
		/// </summary>
		public void upload(URLRequest request, string uploadDataFieldName, bool testUpload)
		{
		}

		/// <summary>
		/// Starts the upload of a file selected by a user to a remote server.
		/// </summary>
		public void upload(URLRequest request, string uploadDataFieldName)
		{
		}

		/// <summary>
		/// Starts the upload of a file selected by a user to a remote server.
		/// </summary>
		public void upload(URLRequest request)
		{
		}

		/// <summary>
		/// Creates a new FileReference object.
		/// </summary>
		public FileReference()
		{
		}

		/// <summary>
		/// Dispatched when a file upload or download is canceled through the file-browsing dialog box by the user.
		/// </summary>
		[As3Event("Event.CANCEL")]
		public event Action<Event> cancelled;

		/// <summary>
		/// Dispatched when download is complete or when upload generates an HTTP status code of 200.
		/// </summary>
		[As3Event("Event.COMPLETE")]
		public event Action<Event> complete;

		/// <summary>
		/// Dispatched when an upload fails and an HTTP status code is available to describe the failure.
		/// </summary>
		[As3Event("HTTPStatusEvent.HTTP_STATUS")]
		public event Action<HTTPStatusEvent> httpStatus;

		/// <summary>
		/// Dispatched when the upload or download fails.
		/// </summary>
		[As3Event("IOErrorEvent.IO_ERROR")]
		public event Action<IOErrorEvent> ioError;

		/// <summary>
		/// Dispatched when an upload or download operation starts.
		/// </summary>
		[As3Event("Event.OPEN")]
		public event Action<Event> open;

		/// <summary>
		/// Dispatched periodically during the file upload or download operation.
		/// </summary>
		[As3Event("ProgressEvent.PROGRESS")]
		public event Action<ProgressEvent> progress;

		/// <summary>
		/// Dispatched when a call to the FileReference.upload() or FileReference.download() method tries to upload a file to a server or get a file from a server that is outside the caller's security sandbox.
		/// </summary>
		[As3Event("SecurityErrorEvent.SECURITY_ERROR")]
		public event Action<SecurityErrorEvent> securityError;

		/// <summary>
		/// Dispatched when the user selects a file for upload or download from the file-browsing dialog box.
		/// </summary>
		[As3Event("Event.SELECT")]
		public event Action<Event> select;

		/// <summary>
		/// Dispatched after data is received from the server after a successful upload.
		/// </summary>
		[As3Event("DataEvent.UPLOAD_COMPLETE_DATA")]
		public event Action<DataEvent> uploadCompleteData;
	}
}