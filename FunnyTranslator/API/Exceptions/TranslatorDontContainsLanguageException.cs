using System;

namespace FunnyTranslator.API.Exceptions
{
    public class TranslatorDontContainsLanguageException : Exception
    {
        public TranslatorDontContainsLanguageException()
        {

        }

        public TranslatorDontContainsLanguageException(string message) : base(message)
        {

        }

        public TranslatorDontContainsLanguageException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
