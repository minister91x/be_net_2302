﻿namespace WebApplicationCoreAPI
{
    public class GetTextInputRequest
    {
        /// <summary>
        /// Trường này là điển nội dung muốn hiển thị
        /// </summary>
        public string? Text { get; set; }
    }

    public class StudentGetlistInputRequest
    {
        /// <summary>
        /// Trường này là điển nội dung muốn hiển thị
        /// </summary>
        public string? Name { get; set; }
    }

    public class ProductGetlistInputRequest
    {
        /// <summary>
        /// Trường này là điển nội dung muốn hiển thị
        /// </summary>
        public string? MaSP { get; set; }

        public string? TenSP { get; set; }
    }
}
