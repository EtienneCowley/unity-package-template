deploy:
	git push origin `git subtree split --prefix Assets/Plugins/UnityPackageTemplate master`:upm --force
