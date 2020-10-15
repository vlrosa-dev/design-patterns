using System;
using System.Collections.Generic;

public class SingletonBalancer
{
    private static SingletonBalancer _instance;
	private List<string> _freeServers = new List<string>();
	private List<string> _busyServers = new List<string>();
	private Random _random = new Random();
	private SingletonBalancer()
	{
		_freeServers.Add("server1");
		_freeServers.Add("server2");
		_freeServers.Add("server3");
		_freeServers.Add("server4");
		_freeServers.Add("server5");
		_freeServers.Add("server6");
	}
	public static SingletonBalancer GetInstance()
	{
		if (_instance == null)
		{
			_instance = new SingletonBalancer();
		}
		return _instance;
	}
	public string GetServer()
	{
		if (_freeServers.Count < 1)
			throw new Exception("No more Servers");

		int r = _random.Next(_freeServers.Count);
		string server = _freeServers[r];
		_busyServers.Add(server);
		_freeServers.Remove(server);
		return server;
	}
}

