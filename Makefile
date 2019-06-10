deploy:
	git subtree push --prefix Assets/Plugins/UnityPackageTemplate origin upm

deploy-force:
	git push origin `git subtree split --prefix Assets/Plugins/UnityPackageTemplate master`:upm --force
