﻿using PortfolioCalculatorApp.Model;

namespace PortfolioCalculatorApp.Views.Interfaces;

public interface IMainAppFormView
{
    string ApiKey1 { get; set; }
    string ApiKey2 { get; set; }

    public bool IsApiKey1Valid { get; set; }
    public bool IsApiKey2Valid { get; set; }

    public string ApiKey1Status { get; set; }
    public string ApiKey2Status { get; set; }
    ListBox ListBoxPortfolios { get; set; }
    string ApiKey3 { get; set; }
    string LabelEarnLossRatio { get; set; }
    string LabelTotalInvested { get; set; }
    string LabelCurrentValue { get; set; }
    bool IsApiKey3Valid { get; set; }
    ComboBox ComboBoxCurrencies { get; }

    public event EventHandler ValidateApiKey;
    public event EventHandler SaveApiKey;
    public event EventHandler LoadApiKeys;
    event EventHandler<ListBox> SavePortfolios;
    event EventHandler LoadSavedPortfolios;
    event EventHandler<PortfolioModel> PortfolioSelected;
    event EventHandler OpenAddPortfolioForm;
    event EventHandler<ListBox> DeleteSelectedItem;
    event EventHandler<PortfolioModel> CalculatePortfolio;
    event EventHandler<ComboBox> InitializeCurrencyComboBox;
}