package com.veyselkaranitekgoz.notebaseandroid.core.DTOs;

import java.util.Date;

public class TokenDto {
    private String AccessToken;

    private Date AccessTokenExpiration;

    private String RefreshToken;

    private Date RefreshTokenExpiration;

    public String getAccessToken() {
        return AccessToken;
    }

    public void setAccessToken(String accessToken) {
        AccessToken = accessToken;
    }

    public Date getAccessTokenExpiration() {
        return AccessTokenExpiration;
    }

    public void setAccessTokenExpiration(Date accessTokenExpiration) {
        AccessTokenExpiration = accessTokenExpiration;
    }

    public String getRefreshToken() {
        return RefreshToken;
    }

    public void setRefreshToken(String refreshToken) {
        RefreshToken = refreshToken;
    }

    public Date getRefreshTokenExpiration() {
        return RefreshTokenExpiration;
    }

    public void setRefreshTokenExpiration(Date refreshTokenExpiration) {
        RefreshTokenExpiration = refreshTokenExpiration;
    }
}
