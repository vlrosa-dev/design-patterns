using System;
using System.Collections.Generic;
using System.Text;

public class EmailDirector
{
	private IEmailBuilder _builder;
	public EmailDirector(IEmailBuilder builder)
	{
		_builder = builder;
	}
	
	public Email Work()
	{
		return _builder.To("rmcs87@gmail.com")
						.From("ricardo.costa@uvv.br")
						.Subject("Teste")
						.Body("Testando o Builder de Emails")
						.Anexo("foto.jpg")
						.Build();
	}
}
