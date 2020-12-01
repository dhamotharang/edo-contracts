# Inter-service API contracts
## Summary
Strongly typed models for EDO and Connectors data exchange

## New version release steps
1. Changes in code
2. Version update (`Version` tag `<Version>{new_version}</Version>)` using guide: https://semver.org/
3. Package release notes update (`PackageReleaseNotes` tag `<PackageReleaseNotes>{whats_new}</PackageReleaseNotes>`) containing changes description
4. Pull request

## Automation
New package version is automatically published to github packages https://github.com/features/packages after changes in `master` branch.

## Dependent projects update
All projects referencing the package should be updated at one time to preserve consistency
