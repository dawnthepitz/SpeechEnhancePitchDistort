function VoiceChange(wavFile,gender)
    [data fs]=SpectralSub(wavFile);
    if gender==0
        malSound=pitchShift(data,1024,256,-2);
        sound(malSound,fs);
    else if gender==1
        femSound=pitchShift(data,1024,256,2);
        sound(femSound,fs);
        else
            disp('You Didn''t pick an appropriate Gender');
        end
    end
end