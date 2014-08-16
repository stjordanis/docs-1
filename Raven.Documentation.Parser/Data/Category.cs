namespace Raven.Documentation.Parser.Data
{
	using System.ComponentModel;

	using Raven.Documentation.Parser.Attributes;

	public enum Category
	{
		[Prefix("client-api")]
		[Description("Client API")]
		ClientApi,

		[Prefix("server")]
		Server,

		[Prefix("studio")]
		Studio,

		[Prefix("transformers")]
		Transformers,

		[Prefix("indexes")]
		Indexes,

		[Prefix("glossary")]
		Glossary,

		[Prefix("start")]
		[Description("Getting started")]
		Start
	}
}