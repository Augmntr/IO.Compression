﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augmntr.IO.Compression
{
    public class SR
    {
        public const string ArgumentOutOfRange_Enum = "Enum value was out of legal range.";
        public const string ArgumentOutOfRange_NeedPosNum = "Positive number required.";
        public const string CannotReadFromDeflateStream = "Reading from the compression stream is not supported.";
        public const string CannotWriteToDeflateStream = "Writing to the compression stream is not supported.";
        public const string GenericInvalidData = "Found invalid data while decoding.";
        public const string InvalidArgumentOffsetCount = "Offset plus count is larger than the length of target array.";
        public const string InvalidBeginCall = "Only one asynchronous reader or writer is allowed time at one time.";
        public const string InvalidBlockLength = "Block length does not match with its complement.";
        public const string InvalidHuffmanData = "Failed to construct a huffman tree using the length array.The stream might be corrupted.";
        public const string NotSupported = "This operation is not supported.";
        public const string NotSupported_UnreadableStream = "Stream does not support reading.";
        public const string NotSupported_UnwritableStream = "Stream does not support writing.";
        public const string ObjectDisposed_StreamClosed = "Can not access a closed Stream.";
        public const string UnknownBlockType = "Unknown block type. Stream might be corrupted.";
        public const string UnknownState = "Decoder is in some unknown state.This might be caused by corrupted data.";
        public const string ZLibErrorDLLLoadError = "The underlying compression routine could not be loaded correctly.";
        public const string ZLibErrorInconsistentStream = "The stream state of the underlying compression routine is inconsistent.";
        public const string ZLibErrorIncorrectInitParameters = "The underlying compression routine received incorrect initialization parameters.";
        public const string ZLibErrorNotEnoughMemory = "The underlying compression routine could not reserve sufficient memory.";
        public const string ZLibErrorVersionMismatch = "The version of the underlying compression routine does not match expected version.";
        public const string ZLibErrorUnexpected = "The underlying compression routine returned an unexpected error code.";
        public const string ArgumentNeedNonNegative = "The argument must be non-negative.";
        public const string CannotBeEmpty = "String cannot be empty.";
        public const string CDCorrupt = "Central Directory corrupt.";
        public const string CentralDirectoryInvalid = "Central Directory is invalid.";
        public const string CreateInReadMode = "Cannot create entries on an archive opened in read mode.";
        public const string CreateModeCapabilities = "Cannot use create mode on a non-writable stream.";
        public const string CreateModeCreateEntryWhileOpen = "Entries cannot be created while previously created entries are still open.";
        public const string CreateModeWriteOnceAndOneEntryAtATime = "Entries in create mode may only be written to once, and only one entry may be held open at a time.";
        public const string DateTimeOutOfRange = "The DateTimeOffset specified cannot be converted into a Zip file timestamp.";
        public const string DeletedEntry = "Cannot modify deleted entry.";
        public const string DeleteOnlyInUpdate = "Delete can only be used when the archive is in Update mode.";
        public const string DeleteOpenEntry = "Cannot delete an entry currently open for writing.";
        public const string EntriesInCreateMode = "Cannot access entries in Create mode.";
        public const string EntryNameEncodingNotSupported = "The specified entry name encoding is not supported.";
        public const string EntryNamesTooLong = "Entry names cannot require more than 2^16 bits.";
        public const string EntryTooLarge = "Entries larger than 4GB are not supported in Update mode.";
        public const string EOCDNotFound = "End of Central Directory record could not be found.";
        public const string FieldTooBigCompressedSize = "Compressed Size cannot be held in an Int64.";
        public const string FieldTooBigLocalHeaderOffset = "Local Header Offset cannot be held in an Int64.";
        public const string FieldTooBigNumEntries = "Number of Entries cannot be held in an Int64.";
        public const string FieldTooBigOffsetToCD = "Offset to Central Directory cannot be held in an Int64.";
        public const string FieldTooBigOffsetToZip64EOCD = "Offset to Zip64 End Of Central Directory record cannot be held in an Int64.";
        public const string FieldTooBigStartDiskNumber = "Start Disk Number cannot be held in an Int64.";
        public const string FieldTooBigUncompressedSize = "Uncompressed Size cannot be held in an Int64.";
        public const string FrozenAfterWrite = "Cannot modify entry in Create mode after entry has been opened for writing.";
        public const string HiddenStreamName = "A stream from ZipArchiveEntry has been disposed.";
        public const string LengthAfterWrite = "Length properties are unavailable once an entry has been opened for writing.";
        public const string LocalFileHeaderCorrupt = "A local file header is corrupt.";
        public const string NumEntriesWrong = "Number of entries expected in End Of Central Directory does not correspond to number of entries in Central Directory.";
        public const string OffsetLengthInvalid = "The offset and length parameters are not valid for the array that was given.";
        public const string ReadingNotSupported = "This stream from ZipArchiveEntry does not support reading.";
        public const string ReadModeCapabilities = "Cannot use read mode on a non-readable stream.";
        public const string ReadOnlyArchive = "Cannot modify read-only archive.";
        public const string SeekingNotSupported = "This stream from ZipArchiveEntry does not support seeking.";
        public const string SetLengthRequiresSeekingAndWriting = "SetLength requires a stream that supports seeking and writing.";
        public const string SplitSpanned = "Split or spanned archives are not supported.";
        public const string UnexpectedEndOfStream = "Zip file corrupt: unexpected end of stream reached.";
        public const string UnsupportedCompression = "The archive entry was compressed using an unsupported compression method.";
        public const string UnsupportedCompressionMethod = "The archive entry was compressed using {0} and is not supported.";
        public const string UpdateModeCapabilities = "Update mode requires a stream with read, write, and seek capabilities.";
        public const string UpdateModeOneStream = "Entries cannot be opened multiple times in Update mode.";
        public const string WritingNotSupported = "This stream from ZipArchiveEntry does not support writing.";
        public const string Zip64EOCDNotWhereExpected = "Zip 64 End of Central Directory Record not where indicated.";
        public const string Argument_InvalidPathChars = "Illegal characters in path.";

        public static string Format( string s, Exception ex )
        {
            return string.Format(s, ex);
        }
    }
}
