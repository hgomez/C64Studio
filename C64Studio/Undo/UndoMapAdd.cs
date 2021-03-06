﻿using System;
using System.Collections.Generic;
using System.Text;
using C64Studio.Formats;



namespace C64Studio.Undo
{
  public class UndoMapAdd : UndoTask
  {
    public MapEditor              _MapEditor = null;
    public MapProject             _MapProject = null;
    public int                    _MapIndex = -1;



    public UndoMapAdd( MapEditor Editor, MapProject Project, int MapIndex )
    {
      _MapEditor  = Editor;
      _MapProject = Project;
      _MapIndex   = MapIndex;
    }




    public string Description
    {
      get
      {
        return "Add Map";
      }
    }



    public override UndoTask CreateComplementaryTask()
    {
      return new UndoMapRemove( _MapEditor, _MapProject, _MapIndex );
    }



    public override void Apply()
    {
      _MapEditor.RemoveMap( _MapIndex );
    }
  }
}
