﻿using System.Windows.Forms;
using PortfolioCalculatorApp.EventArguments;

namespace PortfolioCalculatorApp.Views.Interfaces;

public interface IApiKeyTabView
{
	string ApiKey1 { get; set; }
	string ApiKey2 { get; set; }

	public bool IsApiKey1Valid { get; set; }
	public bool IsApiKey2Valid { get; set; }

	public string ApiKey1Status { get; set; }
	public string ApiKey2Status { get; set; }

	public string ApiKeyStatusStrip { get; set; }
	public string MainMenuStatusStrip { get; set; }

	public Label MainMenuBlockerLabel { get; set; }
	public Panel MainMenuBlockerPanel { get; set; }


	public event EventHandler ValidateApiKey;
	public event EventHandler SaveApiKey;
	public event EventHandler LoadApiKeys;
}