import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Saas',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44313',
    redirectUri: baseUrl,
    clientId: 'Saas_App',
    responseType: 'code',
    scope: 'offline_access Saas role email openid profile',
  },
  apis: {
    default: {
      url: 'https://localhost:44313',
      rootNamespace: 'Dyabp.Saas',
    },
    Saas: {
      url: 'https://localhost:44329',
      rootNamespace: 'Dyabp.Saas',
    },
  },
} as Environment;
