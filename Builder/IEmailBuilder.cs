﻿public interface IEmailBuilder
{
    IEmailBuilder Body(string content);
    IEmailBuilder From(string address);
    IEmailBuilder To(string address);
    IEmailBuilder Subject(string subject);
    IEmailBuilder Anexo(string fileName);
    Email Build();
}
