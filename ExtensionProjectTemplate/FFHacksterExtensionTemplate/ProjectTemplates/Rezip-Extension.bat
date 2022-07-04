
@setlocal

@set ffdir=FFHacksterEx Extension
@set ffzip=FFHacksterEx Extension.zip

@echo Zipping extension template...
@if exist "%ffzip%" @del "%ffzip%"
@7z a "%ffzip%" ".\%ffdir%\*"
@echo Extension template zipped.
@endlocal