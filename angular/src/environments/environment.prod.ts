import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TrainMetasolAbp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44358/',
    redirectUri: baseUrl,
    clientId: 'TrainMetasolAbp_App',
    responseType: 'code',
    scope: 'offline_access TrainMetasolAbp',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44342',
      rootNamespace: 'TrainMetasolAbp',
    },
  },
} as Environment;
