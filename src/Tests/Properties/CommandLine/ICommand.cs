/*
 * Created by: Stephan Brenner
 * Created: 06/18/2007
 */

using System;

namespace Brenner.Common.CommandLine
{
  internal interface ICommand
  {
    void Execute();
    Type ArgsType { get;}
    string Tag { get; }
    bool ShowHelp { get; }
  }
}