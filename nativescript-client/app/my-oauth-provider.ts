import { TnsOaProvider, TnsOaProviderOptions, OpenIdSupportFull, TnsOaOpenIdProviderOptions } from "nativescript-oauth2/providers";
import { ITnsOAuthTokenResult } from "nativescript-oauth2";


export interface TnsOaMyCustomProviderOptions extends TnsOaOpenIdProviderOptions { }

export class TnsOaProviderMyCustomProvider implements TnsOaProvider {
    public options: TnsOaProviderOptions;
    public openIdSupport: OpenIdSupportFull = "oid-full";
    public providerType = "myCustomProvider";
    public authority = "http://10.0.2.2:5010";
    public tokenEndpointBase = "http://10.0.2.2:5010";
    public authorizeEndpoint = "/connect/authorize";
    public tokenEndpoint = "/connect/token";
    public cookieDomains = ["10.0.2.2:5010"];

    constructor(options: TnsOaMyCustomProviderOptions) {
        this.options = options;
    }

    public parseTokenResult(jsonData): ITnsOAuthTokenResult {
        console.log("jsonData");
        console.log(jsonData);
        return jsonData;
    }
}

