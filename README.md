<p align="center">
  <img src="https://i.imgur.com/GZHodUG.png" width="100px"/>
  <h3 align="center">Awesome Github Stats</h3>
</p>

<p align="center">
  Display your total contributions, current streak,
  <br/>
  and longest streak on your GitHub profile README
</p>

<p align="center">
  <a href="https://discord.gg/fPrdqh3Zfu" alt="Discord" title="Dev Pro Tips Discussion & Support Server">
    <img src="https://img.shields.io/discord/819650821314052106?color=7289DA&logo=discord&logoColor=white&style=for-the-badge"/></a>
</p>

## 📃 Table of Contents

- [📃 Table of Contents](#-table-of-contents)
- [⚡ Quick setup](#-quick-setup)
- [⚙ Demo Site](#-demo-site)
- [🖌 Themes](#-themes)
- [🔧 Options](#-options)
- [ℹ️ How these stats are calculated](#ℹ️-how-these-stats-are-calculated)
- [📤 Deploying it on your own](#-deploying-it-on-your-own)
- [🤗 Contributing](#-contributing)
- [🙋‍♂️ Support](#️-support)

## ⚡ Quick setup

1. Copy-paste the markdown below into your GitHub profile README
2. Replace the value after `?user=` with your GitHub username

```md
[![GitHub Streak](https://github-readme-streak-stats.herokuapp.com/?user=DenverCoder1)](https://git.io/streak-stats)
```

> Note: See below for information about deploying the app on your own

## ⚙ Demo Site

Here you can customize your Streak Stats card with a live preview.

<http://github-readme-streak-stats.herokuapp.com/demo/>

[![Demo Site](https://user-images.githubusercontent.com/20955511/114579753-dbac8780-9c86-11eb-97dd-207039f67d20.gif "Demo Site")](http://github-readme-streak-stats.herokuapp.com/demo/)

## 🖌 Themes

To enable a theme, append `&theme=` followed by the theme name to the end of the source url:

```md
[![GitHub Streak](https://github-readme-streak-stats.herokuapp.com/?user=DenverCoder1&theme=dark)](https://git.io/streak-stats)
```

|     Theme      |                              Preview                                |
| :------------: | :-----------------------------------------------------------------: |
|   `default`    |             ![default](https://i.imgur.com/IaTuYdS.png)             |
|     `dark`     |              ![dark](https://i.imgur.com/bUrsjlp.png)               |
| `highcontrast` |          ![highcontrast](https://i.imgur.com/ovrVrTY.png)           |
|  More themes!  | **🎨 [See a list of all available themes](./docs/themes/README.md)** |

> If you have come up with a new theme you'd like to share with others, open an issue to add it!

## 🔧 Options

The `user` field is the only required option. All other fields are optional.

If the `theme` parameter is specified, any color customizations specified will be applied on top of the theme, overriding the theme's values.

|     Parameter     |                    Details                     |                        Example                        |
| :---------------: | :--------------------------------------------: | :---------------------------------------------------: |
|      `user`       |       GitHub username to show stats for        |                    `DenverCoder1`                     |
|      `theme`      |    The theme to apply (Default: `default`)     | `dark`, `radical`, etc. [🎨➜](./docs/themes/README.md) |
|   `hide_border`   | Make the border transparent (Default: `false`) |                   `true` or `false`                   |
|   `background`    |                Background color                |      **hex code** (without `#`) or **css color**      |
|     `border`      |                  Border color                  |      **hex code** (without `#`) or **css color**      |
|     `stroke`      |       Stroke line color between sections       |      **hex code** (without `#`) or **css color**      |
|      `ring`       |  Color of the ring around the current streak   |      **hex code** (without `#`) or **css color**      |
|      `fire`       |         Color of the fire in the ring          |      **hex code** (without `#`) or **css color**      |
|  `currStreakNum`  |             Current streak number              |      **hex code** (without `#`) or **css color**      |
|    `sideNums`     |        Total and longest streak numbers        |      **hex code** (without `#`) or **css color**      |
| `currStreakLabel` |              Current streak label              |      **hex code** (without `#`) or **css color**      |
|   `sideLabels`    |        Total and longest streak labels         |      **hex code** (without `#`) or **css color**      |
|      `dates`      |             Date range text color              |      **hex code** (without `#`) or **css color**      |

### Example

```md
[![GitHub Streak](https://github-readme-streak-stats.herokuapp.com/?user=denvercoder1&currStreakNum=2FD3EB&fire=pink&sideLabels=F00)](https://git.io/streak-stats)
```

## ℹ️ How these stats are calculated

This tool uses the contribution graphs on your GitHub profile to calculate which days you have contributed.

To include contributions in private repositories, turn on the setting for "Private contributions" from the dropdown menu above the contribution graph on your profile page.

Contributions include commits, pull requests, and issues that you create in standalone repositories ([Learn more about what is considered a contribution](https://docs.github.com/articles/why-are-my-contributions-not-showing-up-on-my-profile)).

The longest streak is the highest number of consecutive days on which you have made at least one contribution.

The current streak is the number of consecutive days ending with the current day on which you have made at least one contribution. If you have made a contribution today, it will be counted towards the current streak, however, if you have not made a contribution today, the streak will only count days before today so that your streak will not be zero.

> Note: You may need to wait up to 24 hours for new contributions to show up ([Learn how contributions are counted](https://docs.github.com/articles/why-are-my-contributions-not-showing-up-on-my-profile))

## 📤 Deploying it on your own

If you can, it is preferable to host the files on your own server.

Doing this can lead to better uptime and more control over customization (you can modify the code for your usage).

You can deploy the PHP files on any website server with PHP installed or as a Heroku app.

[![Deploy](https://www.herokucdn.com/deploy/button.svg "Deploy to Heroku")](https://heroku.com/deploy?template=https://github.com/DenverCoder1/github-readme-streak-stats/tree/main)

## 🤗 Contributing

Contributions are welcome! Feel free to open an issue or submit a pull request if you have a way to improve this project.

Make sure your request is meaningful and you have tested the app locally before submitting a pull request.

### Installing Requirements

#### Requirements

- [PHP 7.4+](https://www.apachefriends.org/index.html)
- [Composer](https://getcomposer.org)

#### Linux

```bash
sudo apt-get install php
sudo apt-get install php-curl
sudo apt-get install composer
```

#### Windows

Install PHP from [XAMPP](https://www.apachefriends.org/index.html) or [php.net](https://windows.php.net/download)

[▶ How to install and run PHP using XAMPP (Windows)](https://www.youtube.com/watch?v=K-qXW9ymeYQ)

[📥 Download Composer](https://getcomposer.org/download/)

### Clone the repository

```bash
git clone https://github.com/DenverCoder1/github-readme-streak-stats.git
cd github-readme-streak-stats
```

### Authorization

To get the GitHub API to run locally you will need to provide a token.

1. Go to <https://github.com/settings/tokens>
2. Click **"Generate new token"**
3. Add a note (ex. **"GitHub Readme Streak Stats"**), then scroll to the bottom and click **"Generate token"**
4. **Copy** the token to your clipboard
5. **Create** a file `config.php` in the `src` directory and replace `ghp_example123` with **your token** and `DenverCoder1` with **your username**:

```php
# /src/config.php
<?php
putenv("TOKEN=ghp_example123");
putenv("USERNAME=DenverCoder1");
```

### Running the app locally

```bash
composer start
```

Open <http://localhost:8000/?user=DenverCoder1> to run the project locally.

Open <http://localhost:8000/demo/> to run the demo site.

### Running the tests

Before you can run tests, PHPUnit must be installed. You can install it using Composer by running the following command.

```bash
composer install
```

Run the following command to run the PHPUnit test script which will verify that the tested functionality is still working.

```bash
composer test
```

## 🙋‍♂️ Support

💙 If you like this project, give it a ⭐ and share it with friends!

<p align="left">
  <a href="https://www.youtube.com/channel/UCipSxT7a3rn81vGLw9lqRkg?sub_confirmation=1"><img alt="Youtube" title="Youtube" src="https://img.shields.io/badge/-Subscribe-red?style=for-the-badge&logo=youtube&logoColor=white"/></a>
  <a href="https://github.com/sponsors/DenverCoder1"><img alt="Sponsor with Github" title="Sponsor with Github" src="https://img.shields.io/badge/-Sponsor-ea4aaa?style=for-the-badge&logo=github&logoColor=white"/></a>
</p>

[☕ Buy me a coffee](https://ko-fi.com/jlawrence)

---

Made with ❤️ and PHP

<a href="https://heroku.com/"><img alt="Powered by Heroku" title="Powered by Heroku" src="https://img.shields.io/badge/-Powered%20by%20Heroku-6567a5?style=for-the-badge&logo=heroku&logoColor=white"/></a>