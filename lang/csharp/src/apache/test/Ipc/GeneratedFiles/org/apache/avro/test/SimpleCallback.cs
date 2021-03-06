// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.vshost.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace org.apache.avro.test
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	/// <summary>
	/// Protocol used for testing.
	/// </summary>
	public abstract class SimpleCallback : Simple
	{
		// Send a greeting
		public abstract void hello(string greeting, Avro.IO.ICallback<System.String> callback);
		// Pretend you're in a cave!
		public abstract void echo(org.apache.avro.test.TestRecord record, Avro.IO.ICallback<org.apache.avro.test.TestRecord> callback);
		public abstract void add(int arg1, int arg2, Avro.IO.ICallback<System.Int32> callback);
		public abstract void echoBytes(byte[] data, Avro.IO.ICallback<System.Byte[]> callback);
		// Always throws an error.
		public abstract void error(Avro.IO.ICallback<System.Object> callback);
	}
}
