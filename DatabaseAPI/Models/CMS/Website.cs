﻿namespace DatabaseAPI.Models.CMS
{
    //class with generic websites
    public class Website
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? TitleName { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
    }
}
