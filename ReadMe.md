[![Build Status](https://travis-ci.org/kirkchen/NLog.HipChat.png?branch=master)](https://travis-ci.org/kirkchen/NLog.HipChat)

# Nlog.HipChat 

This is a [NLog](https://github.com/NLog/NLog "NLog") target for hipchat. Allow you sending certain log message to your hipchat chatroom.

So that you can recieve message when your application occurs error immediately.

## How to use?

1. To install NLog.HipChat, run the following command in the Package Manager Console

		Install-Package NLog.HipChat -Version 0.0.1

1. setting nlog.config, update your **Api Key**, **Room Id**, **Sender Name**

		<?xml version="1.0" encoding="utf-8" ?>
			<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  			<extensions>
				<add assembly="NLog.HipChat"/>
  			</extensions>
  			<targets>   
				<target name="hipChat" xsi:type="HipChat" 
						authToken="{authtoken}" 
						roomId="{roomid}" 
						senderName="{sender}" 
						backgroundColor="red"
						layout="${message}"/>
  			</targets>
  			<rules>   
				<logger name="*" minlevel="Error" writeTo="hipChat" />
  			</rules>
		</nlog>

## Project Reference Home

* Nuget - https://www.nuget.org/packages/NLog.HipChat/
* NLog - https://github.com/NLog/NLog
* HipChat.Net - https://github.com/hugorodgerbrown/HipChat.net

## LICENSE

(The MIT License)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the 'Software'), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.