﻿using System;

namespace Kermalis.VGMusicStudio.Core
{
    internal enum PlayerState : byte
    {
        Stopped,
        Playing,
        Paused,
        ShutDown
    }

    internal delegate void SongEndedEvent();

    internal interface IPlayer : IDisposable
    {
        PlayerState State { get; }
        event SongEndedEvent SongEnded;

        void LoadSong(long index);
        void Play();
        void Pause();
        void Stop();
        void GetSongState(UI.TrackInfoControl.TrackInfo info);
    }
}
