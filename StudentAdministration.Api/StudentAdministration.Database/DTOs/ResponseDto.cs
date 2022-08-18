namespace StudentAdministration.Database.DTOs
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        public ResponseDto(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
