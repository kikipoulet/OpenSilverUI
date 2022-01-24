# OpenSilverUI

Simple UI Library compatible with OpenSilver - just a POC 

## Installation

- Install the Nuget package "OpenSilverUI"
- Reference OpenSilverUI in your App.xaml file

```
<Application ...>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="/OpenSilverUI;component/Components/OpenSilverUI.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

# Usage
## Buttons

<img src="https://raw.githubusercontent.com/kikipoulet/OpenSilverUI/main/images/buttons.png"></img>

```
<Button Content="Primary"Style="{StaticResource PrimaryButton}"  Width="100"></Button>
<Button Content="Secondary" Style="{StaticResource SecondaryButton}" Width="100"></Button>
<Button Content="Light" Style="{StaticResource LightButton}" Width="100"></Button>
<Button Content="Success" Style="{StaticResource SuccessButton}" Width="100"></Button>
<Button Content="Success Light" Style="{StaticResource SuccessLightButton}" Width="100"></Button>
<Button Content="Warning"Style="{StaticResource WarningButton}" Width="100"></Button>
<Button Content="Warning Light" Style="{StaticResource WarningLightButton}" Width="100"></Button>
<Button Content="Danger" Style="{StaticResource DangerButton}" Width="100"></Button>
<Button Content="Danger Light" Style="{StaticResource DangerLightButton}" Width="100"></Button>
                 
```

## Switch
<img src="https://raw.githubusercontent.com/kikipoulet/OpenSilverUI/main/images/switchs.png"></img>

```
<CheckBox Style="{StaticResource Switch}"></CheckBox>
<CheckBox IsChecked="True" Style="{StaticResource Switch}"></CheckBox>
```

## MessageBox
<img src="https://raw.githubusercontent.com/kikipoulet/OpenSilverUI/main/images/messagebox.png"></img>
```
 new MessageWindow("Title", "Message").Show();
 ```

> Use Style="{StaticResource MessageBoxStyle}" in a ChildWindow to make your own Window
## ComboBox
<img src="https://raw.githubusercontent.com/kikipoulet/OpenSilverUI/main/images/combobox.png"></img>
```
<ComboBox UseNativeComboBox="False" Style="{StaticResource ComboBoxOS}"></ComboBox>
```
## TextBox
<img src="https://raw.githubusercontent.com/kikipoulet/OpenSilverUI/main/images/textbox.png"></img>
```
<TextBox Style="{StaticResource TextBoxOS}"  Text="content"></TextBox>
```
