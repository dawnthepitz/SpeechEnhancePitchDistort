function VoiceChange(wavFile,gender)
    [data fs]=SpectralSub(wavFile);
    if gender==0
        malSound=pitchShift(data,round(fs/43.06640625),round((fs/43.06640625))/4,-2);
        sound(malSound,fs);
    else if gender==1
        femSound=pitchShift(data,round(fs/43.06640625),round((fs/43.06640625)/4),2);
        sound(femSound,fs);
        else
            disp('You Didn''t pick an appropriate Gender');
        end
    end
end