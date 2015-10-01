function [output fs]=SpectralSub(speechSound)
    [signal,fs]=wavread(speechSound);
    figure
    plot(signal)
    xlabel('Speech Sound Original Plot');
    output=SSBoll79(signal,fs);
end